local socket = require 'socket'

local t = {}

local vmath = {
  vector3 = function(_x, _y, _z) 
    return {
      x = _x or 0,
      y = _y or 0,
      z = _z or 0
    }
  end
}

function init(self)
  self.velocity = vmath.vector3()
end

function fixed_update(self)
  self.velocity.y = self.velocity.y + 1
  print(self.velocity.y)
end

init(t)

while true do
  socket.sleep(0.5)
  fixed_update(t)
end
