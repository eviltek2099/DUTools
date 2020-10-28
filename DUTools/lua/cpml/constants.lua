-- @module constants

local constants = {}

-- NQ
constants.deg2rad = 0.0174532925199
constants.rad2deg = 57.2957795130
constants.epsilon = 0.000001

-- same as C's FLT_EPSILON
constants.FLT_EPSILON = 1.19209290e-07

-- used for quaternion.slerp
constants.DOT_THRESHOLD = 0.9995

return constants
