-- list here all required files, stored in the same folder as global.lua
require 'ControlCommand'
require 'dkjson'
require 'database'
require 'cpml/sgui'


-- prevent abuse by loading C modules
-- see:  https://www.lua.org/manual/5.3/manual.html#pdf-package.searchers
table.remove(package.searchers, 4)
table.remove(package.searchers, 3)

-- binary chunks are not validated by Lua and can crash the interpreter
-- see: https://www.lua.org/manual/5.3/manual.html#pdf-load
do
  local real_load = load
  load = function (chunk, chunkname, mode, env)
    -- if the chunk appears to be binary, raise an error
    -- otherwise, load it as text

    if string.sub(tostring(chunk), 1, 1) == "\27" then -- binary start with ESC=\27
      return nil, "loading of binary chunks is disabled"
    else
      return real_load(chunk, chunkname, "t", env)
    end
  end
end