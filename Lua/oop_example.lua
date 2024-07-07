local Character = {}
Character.__index = Character
do
  local count = 0

  Character.new = function(name)
    Character.increment_count()
    local instance = setmetatable({}, Character)
    
    instance.get_name = function()
      return name
    end
    
    return instance
  end
 
  Character.get_count = function()
    return count
  end
  
  Character.increment_count = function()
    count = count + 1
  end
end

local Player = {}
Player.__index = Player
setmetatable(Player, Character)

local Enemy = {}
Enemy.__index = Enemy
setmetatable(Enemy, Character)

local character_table = {
  Player.new("Bob"),
  Enemy.new("Bill"),
}

for i = 1, #character_table do
  print(character_table[i].get_name())
end
