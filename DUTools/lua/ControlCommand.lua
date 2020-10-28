-- ################################################################################
-- #                  Copyright 2014-2018 Novaquark SAS                           #
-- ################################################################################

-- ********************************************************************************
-- ***************************** CONTROL COMMAND  *********************************
-- ********************************************************************************


vec2      = require("cpml/vec2")
vec3      = require("cpml/vec3")
utils     = require("cpml/utils")
constants = require("cpml/constants")
pid       = require("cpml/pid")

nullvector = vec3.new(0,0,0)
epsilon = 0.001

-- rescale val originally between edge0 and edge1 into the [0,1] segment
function linearUnitaryRescaling(edge0, edge1, val)
    return utils.clamp((val - edge0) / (edge1 - edge0), 0, 1)
end

-- returns the angle made by 'right' against the plane defined by the orthogonal of 'gravityDirection'
-- 'forward' is used as a reference to build up the orthogonal plane.
function getRoll(gravityDirection, forward, right)
    local horizontalRight = gravityDirection:cross(forward):normalize_inplace()
    local roll = math.acos(utils.clamp(horizontalRight:dot(right), -1, 1)) * constants.rad2deg
    if horizontalRight:cross(right):dot(forward) < 0 then roll = -roll end
    return roll
end

-- give the axis and angle of the rotation that transforms oldDir into newDir
-- returns the angle and the axis of rotation
-- If oldDir and newDir are colinear, preferredAxis is returned as the zero rotation axis
function getAxisAngleRad(oldDir, newDir, preferredAxis)
    local axis = oldDir:cross(newDir)
    local axisLen = axis:len()
    local angle = 0
    axis = axis:normalize_inplace()
    if (axisLen > constants.epsilon)
    then
        angle = math.asin(utils.clamp(axisLen, 0, 1))
    else
        axis = preferredAxis
        if oldDir:dot(newDir) < 0
        then --half turn
            angle = 180 * constants.deg2rad
        end
    end
    return axis, angle
end

-- map 'throttle' within the [0, maxSrcForce] segment into the [0, maxDestForce] segment
function remapThrottle(throttle, maxSrcForce, maxDestForce)
    local currentForce = throttle * maxSrcForce
	if math.abs(maxDestForce) > epsilon
	then
		return utils.clamp(currentForce / maxDestForce, -1 ,1)
	else
		return 0
	end
end

-- ********************************************************************************
-- ***************************** THRUST MANAGER OBJECT ****************************
-- ********************************************************************************

ThrustManager = {}
ThrustManager.__index = ThrustManager;

function ThrustManager.new(control, core)
    local self = setmetatable({}, ThrustManager)

	self.control = control
    self.core = core
    self.mass = self.core.getConstructMass()

    self.inspace = 0
    if (self.control.getAtmosphereDensity() == 0) then
        self.inspace = 1
    end

    self.throttle = 0
	self.control.setThrottle(0)
    self.throttleStep = 0.1
	self.throttleMinAttempts = 3
	self.throttleBelowZeroAttempts = self.throttleMinAttempts
	self.throttleAboveZeroAttempts = self.throttleMinAttempts
    local maxKP = self.core.getMaxKinematicsParameters()

    self.maxAtmoForward = maxKP[1]
    self.maxAtmoBackward = maxKP[2]
    self.maxSpaceForward = maxKP[3]
    self.maxSpaceBackward = maxKP[4]

    return self
end

-- integrate the mouswheel commands to change the value of the throttle
function ThrustManager.applyThrottleCommand(self, mouseWheelCommand)

	if math.abs(mouseWheelCommand) < epsilon then return end

	local atmosphereDensity = self.control.getAtmosphereDensity()
	local modify = true

	local newThrottle = self.throttle + self.throttleStep * mouseWheelCommand
	if newThrottle * self.throttle < -epsilon
	then
		self.throttle = 0
		self.control.setThrottle(0)
		return
	end

	if math.abs(self.throttle) < epsilon
	then
		if mouseWheelCommand < 0
		then
			self.throttleBelowZeroAttempts = self.throttleBelowZeroAttempts + 1
			modify = self.throttleBelowZeroAttempts > self.throttleMinAttempts
			if modify == true
			then
				self.throttleAboveZeroAttempts = 0
			end
		else
			self.throttleAboveZeroAttempts = self.throttleAboveZeroAttempts + 1
			modify = self.throttleAboveZeroAttempts > self.throttleMinAttempts
			if modify == true
			then
				self.throttleBelowZeroAttempts = 0
			end
		end
	end

	if modify == true
	then
		self.throttle = self.throttle + self.throttleStep * mouseWheelCommand
		self.throttle = utils.clamp(self.throttle, -1, 1)
		self.control.setThrottle(self.throttle)
	end
end

-- convert atmoThrust <-> spaceThrust when crossing atmosphere limits
function ThrustManager.atmoSpaceSwitching(self)
	local atmosphereDensity = self.control.getAtmosphereDensity()

    if (self.inspace == 0 and atmosphereDensity == 0) then
        if (self.throttle >= 0)
        then
            self.throttle = remapThrottle(self.throttle, self.maxAtmoForward, self.maxSpaceForward)
        else
            self.throttle = remapThrottle(self.throttle, self.maxAtmoBackward, self.maxSpaceBackward)
        end
        self.inspace = 1
    elseif (self.inspace == 1 and atmosphereDensity > 0) then
        if (self.throttle >= 0)
        then
            self.throttle = remapThrottle(self.throttle, self.maxSpaceForward, self.maxAtmoForward)
        else
            self.throttle = remapThrottle(self.throttle, self.maxSpaceBackward, self.maxAtmoBackward)
        end
        self.inspace = 0
    end
end

function ThrustManager.getAccelerationCommand(self)
    local force = 0

    if (self.inspace == 0)
    then
        if (self.throttle > 0)
        then
            force = self.throttle * self.maxAtmoForward
        else
            force = -self.throttle * self.maxAtmoBackward
        end
    else
        if (self.throttle > 0)
        then
            force = self.throttle * self.maxSpaceForward
        else
            force = -self.throttle * self.maxSpaceBackward
        end
    end
    return force / self.mass
end

function ThrustManager.updateCommand(self, mouseWheel)
	self:atmoSpaceSwitching()
	self:applyThrottleCommand(mouseWheel)
end

function ThrustManager.resetThrottle(self)
	self.throttle = 0
	self.control.setThrottle(self.throttle)
end

-- ********************************************************************************
-- ***************************** NAVIGATOR OBJECT *********************************
-- ********************************************************************************

Navigator = {}
Navigator.__index = Navigator;

function Navigator.new(system, core, control)
    local self = setmetatable({}, Navigator)
    self.system = system
    self.core = core
    self.control = control
	self.altitudePID = pid.new(10, 0, 100)
	self.pitchPID = pid.new(1, 0, 10)
	self.rollPID = pid.new(1, 0, 10)
	self.boosterState = 0
	self.boosterStateHasChanged = false

    self.mass = core.getConstructMass()

    self.orient = {
        -- convenient accessors for orientation in construct local coordinates
        up = function() return self.core.getConstructOrientationUp() end,
        forward = function() return self.core.getConstructOrientationForward() end,
        right = function() return self.core.getConstructOrientationRight() end,

        -- convenient accessors for orientation in world coordinates
        worldUp = function() return self.core.getConstructWorldOrientationUp() end,
        worldForward = function() return self.core.getConstructWorldOrientationForward() end,
        worldRight = function() return self.core.getConstructWorldOrientationRight() end,
    }

    --config
	self.inputsInertia = 0.95
    self.upAcceleration = 10
    self.pitchRollSpeed = 5
    self.yawSpeed = 3
    self.inducedRotationFactor = 0.1
	self.altitudeHovercraft = 3.5
	self.brakeFactor = 0.1
    self.brakeMin = 4
    self.minGravity = 0.01
    self.minPlanetInfluence = 0.1
    self.lastRoll = 0
    self.lastPitch = 0
    self.lastYaw = 0
    self.pitchRollAmplitude = 1.0
    self.pitchStabVelocityStart = 10
    self.pitchStabVelocityEnd = 30
    self.rollStabVelocityStart = 110
    self.rollStabVelocityEnd = 150

    -- we use a table here to force passing by ref in the increase/decrease functions
    self.roll = {0}
    self.lift = {0}
    self.pitch = {0}
    self.yaw = {0}
    self.brake = {0}

	self.thrustManager = ThrustManager.new(control, core)

    return self
end

function Navigator.increase(self, x)
    x[1] = x[1] + 1
end

function Navigator.decrease(self, x)
    x[1] = x[1] - 1
end

function Navigator.getRollInput(self)
    self.lastRoll = utils.lerp(self.inputsInertia, self.roll[1], self.lastRoll)
    return self.lastRoll
end

function Navigator.getLiftInput(self)
    return self.lift[1]
end

function Navigator.getBrakeInput(self)
    return self.brake[1]
end

function Navigator.getPitchInput(self)
    self.lastPitch = utils.lerp(self.inputsInertia, self.pitch[1], self.lastPitch)
    return self.lastPitch
end

function Navigator.getYawInput(self)
    self.lastYaw = utils.lerp(self.inputsInertia, self.yaw[1], self.lastYaw)
    return self.lastYaw
end

-- normalization function to reduce the standard angular acceleration command in proportion to the construct size
function Navigator.sizeNormalization(self, angularAcceleration)
	local referenceMass = 1000
	local maxReductionFactor = 10
	local adjustedMass = utils.clamp(self.mass, referenceMass, referenceMass * (maxReductionFactor^3))
	local factor = (referenceMass / adjustedMass) ^ (1/3)

	return factor * angularAcceleration
end

-- true when the ship is in space or on a planet and stabilized with the gravity normal
function Navigator.isStabilized(self)
	local planetInfluence = self.control.getClosestPlanetInfluence()
    local orientUp = vec3(self.orient.worldUp())
	local worldVertical = -vec3(self.core.getWorldVertical())

	if planetInfluence < self.minPlanetInfluence then return true end

    if (worldVertical:len() > epsilon) -- worldVertical is null vector in space.
    then
		return orientUp:dot(worldVertical) > 0.9
	else
		return true
	end
end

-- Compute the target transform
-- if the stabilization factors are equal to 0, it returns the current construct transform
-- if the stabilization factors are equal to 1, it aligns the construct up on -gravity
function Navigator.getStabilizedTransform(self, rollStabFactor, pitchStabFactor)
    local targetUp = vec3(self.orient.worldUp())
    local targetRight = vec3(self.orient.worldRight())
    local targetForward = vec3(self.orient.worldForward())
	local worldVertical = -vec3(self.core.getWorldVertical())

    if (worldVertical:len() > epsilon) -- worldVertical is null vector in space.
    then
    	-- stabilized roll
    	local newUp = worldVertical:project_on_plane(targetForward):normalize_inplace()
    	local stabAxis, stabAngleRad = getAxisAngleRad(targetUp, newUp, targetForward)
    	self.rollPID:inject(stabAngleRad * rollStabFactor)
    	local angle = self.rollPID:get()
    	targetUp = targetUp:rotate(angle, stabAxis)
    	targetRight = targetRight:rotate(angle, stabAxis)
    	targetForward = targetForward:rotate(angle, stabAxis)

    	-- stabilized pitch
    	local newUp = worldVertical:project_on_plane(targetRight):normalize_inplace()
    	stabAxis,stabAngleRad = getAxisAngleRad(targetUp, newUp, targetRight)
    	self.pitchPID:inject(stabAngleRad * pitchStabFactor)
    	local angle = self.pitchPID:get()
    	targetUp = targetUp:rotate(angle, stabAxis)
    	targetRight = targetRight:rotate(angle, stabAxis)
    	targetForward = targetForward:rotate(angle, stabAxis)
    end

    return targetUp, targetRight, targetForward
end

-- compensates gravity, and add an extra punch up or down depending on the key pressed
function Navigator.composeLiftUpAcceleration(self, upInput)
	local orientUp = vec3(self.orient.worldUp())
	local worldVertical = -vec3(self.core.getWorldVertical())
	local planetInfluence = self.control.getClosestPlanetInfluence()
	local g = self.core.g()

    local res = nullvector
    if (worldVertical:len() > epsilon) -- worldVertical is null vector in space.
    then
        local atmoUpAcceleration
        local cosVerticalAngle = utils.clamp(orientUp:dot(worldVertical), -1, 1)

        if (math.abs(cosVerticalAngle) > 0.5)
        then
		  atmoUpAcceleration = (g + upInput * self.upAcceleration) / cosVerticalAngle
        else
		  atmoUpAcceleration = g
        end

        res = atmoUpAcceleration * worldVertical
    end

	return res
end

-- controlling altitude with a PID controlled command
function Navigator.composeAltitudeControlAcceleration(self, targetAltitude, altimeter)
	local worldGravity = -vec3(self.core.getWorldGravity())

	local alti = altimeter.getDistance()
	if (alti < 0)
	then
		return nullvector
	end
	local error = targetAltitude - alti
	self.altitudePID:inject(error)
	local command = self.altitudePID:get()
	return command * worldGravity
end

-- generate the ship's main thrust
function Navigator.composeForwardAcceleration(self, accel)
	local orientForward = vec3(self.orient.worldForward())
    local res = accel * orientForward

	return res
end

-- generate artificial friction, including in space, to help better control the ship
function Navigator.composeBrakingAcceleration(self, brakeInput)
    local factor = self.brakeFactor;
    local v = vec3(self.core.getWorldVelocity()):len()
    if (v < epsilon) then return nullvector end
    local intensity = brakeInput * (factor + self.brakeMin / v)

	return -intensity * vec3(self.core.getWorldVelocity())
end

-- the induced rotation is a yaw rotation that will "turn" the ship when it's rolling, inducing a coupled turn&roll movement
function Navigator.composeTiltingAngularAcceleration(self)
	local orientForward = vec3(self.orient.worldForward())
	local orientRight = vec3(self.orient.worldRight())
	local orientUp = vec3(self.orient.worldUp())
	local worldVertical = vec3(self.core.getWorldVertical())
	local atmosphereDensity = self.control.getAtmosphereDensity()

    local res = nullvector
    if (worldVertical:len() > epsilon) -- worldVertical is null vector in space.
    then
        local currentRoll = getRoll(worldVertical, orientForward, orientRight)
        local inducedRotation = (currentRoll * orientForward:cross(worldVertical):len2()) * worldVertical
        inducedRotation = utils.clamp(orientUp:dot(-worldVertical), 0, 1) * inducedRotation

        res = self.inducedRotationFactor * atmosphereDensity * inducedRotation
    end

	return res
end

-- angular acceleration to tend towards a stabilized ship, modified by the orientation command given by the user
function Navigator.composeControlledStabAngularAcceleration(self, rollCommand, pitchCommand)
	local orientForward = vec3(self.orient.worldForward())
	local orientUp = vec3(self.orient.worldUp())
	local forwardVelocity =  vec3(self.core.getWorldVelocity()):dot(orientForward)
	local atmosphereDensity = self.control.getAtmosphereDensity()
	local worldVertical = vec3(self.core.getWorldVertical())
    local orientProjection = math.abs(orientForward:dot(worldVertical))

    -- eval target orientation auto correction
	-- roll is stabilized under rollStabVelocityStart
	local rollStabFactor = 1 - linearUnitaryRescaling(self.rollStabVelocityStart, self.rollStabVelocityEnd, forwardVelocity)
	rollStabFactor = rollStabFactor * (1 - orientProjection) * atmosphereDensity
	-- pitch is stabilized under pitchStabVelocityStart
	local pitchStabFactor = (1 - linearUnitaryRescaling(self.pitchStabVelocityStart, self.pitchStabVelocityEnd, forwardVelocity)) * atmosphereDensity

	-- compute the new target orientation, with possible auto correction
    local targetUp, targetRight, targetForward = self:getStabilizedTransform(rollStabFactor, pitchStabFactor)

	-- apply the user command to shift the computed target
    targetUp = (targetUp + (self.pitchRollAmplitude * rollCommand * targetRight)
	                     + (-self.pitchRollAmplitude * pitchCommand * targetForward)):normalize_inplace()
    local targetAxis, targetAngle = getAxisAngleRad(orientUp, targetUp, targetRight)
    local rollPitchRotation = targetAngle * targetAxis

    local res = self.pitchRollSpeed * rollPitchRotation

	-- mitigate the intensity of the angular acceleration in proportion to the mass (big stuff don't turn as fast as small stuff)
	res = self:sizeNormalization(res)

	return res
end

-- apply the user left/right input to create a yaw angular acceleration
function Navigator.composeTurningAngularAcceleration(self, yawCommand)
	local orientUp = vec3(self.orient.worldUp())

    local yawRotation = yawCommand * orientUp
    local res = self.yawSpeed * yawRotation

	-- mitigate the intensity of the angular acceleration in proportion to the mass (big stuff don't turn as fast as small stuff)
	res = self:sizeNormalization(res)

	return res
end

-- apply the user left/right input to create a yaw angular acceleration
function Navigator.toggleBoosters(self)
    self.boosterStateHasChanged = true
	self.boosterState = 1 - self.boosterState
end

function Navigator.setBoosterCommand(self, tags)
	if self.boosterStateHasChanged then
		self.boosterStateHasChanged = false
		self.control.setEngineThrust("booster", self.boosterState)
	end
end

function Navigator.update(self)
    -- manage the thrust
    self.thrustManager:updateCommand(self.system.getMouseWheel())
end

function Navigator.setEngineCommand(self, tags, acceleration, angularAcceleration)
    -- issues the actual command to the Inertial Control Command
    self.control.setEngineCommand(tags,
	                             {acceleration:unpack()},
                                 {angularAcceleration:unpack()})
end
