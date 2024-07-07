Tree = {}
Tree.__index = Tree

Tree.new = function(colour, name)
    local newTree = {}
    newTree.colour = colour
    newTree.name = name
    setmetatable(newTree, Tree)
    return newTree
end

function Tree:photosynthesise()
  print("The " .. self.name .. " tree is photosynthesising")
end

function Tree:lose_leaves()
  print("The " .. self.colour .. " leaves are swept away by the wind")
end

Deciduous_tree = {}
Deciduous_tree.__index = Deciduous_tree
setmetatable(Deciduous_tree,  Tree)

Deciduous_tree.new = function(colour, name)
    local new_deciduous_tree = Tree.new(colour, name)
    new_deciduous_tree.tree_type = "deciduous"
    setmetatable(new_deciduous_tree, Deciduous_tree)
    return new_deciduous_tree
end

Deciduous_tree.photosynthesise = function(self)
  print("The " .. self.name .. " tree is soaking up the sun")
end

Deciduous_tree.attract_wildlife = function(self)
  print("The " .. self.colour .. " " .. self.name .. " tree suddenly attracts a great magnitude of birds, insects and other critters")
end

Coniferous_tree = {}
Coniferous_tree.__index = Coniferous_tree
setmetatable(Coniferous_tree,  Tree)

Coniferous_tree.new = function(colour, name, location, years)
    local new_coniferous_tree = Tree.new(colour, name)
    new_coniferous_tree.tree_type = "coniferous"
    new_coniferous_tree.location = location
    new_coniferous_tree.years = years
    setmetatable(new_coniferous_tree, Coniferous_tree)
    return new_coniferous_tree
end

function Coniferous_tree:lose_leaves()
  print("The " .. self.colour .. " leaves are shaken away by some pesky kids every " .. self.years .. " years")
end


Coniferous_tree.collapse = function(self)
  print("The " .. self.name .. " falls to the ground with a sudden thud, in the " .. self.location)
end

local trees = {
  Tree.new("purple", "undescovered"),
  Tree.new("yellow", "undetermined"),
  Deciduous_tree.new("red", "apple"),
  Deciduous_tree.new("orange", "maple"),
  Coniferous_tree.new("brown", "pine", "forrest", 2),
  Coniferous_tree.new("green", "Spruce", "park", 7)
}

for i = 1, #trees do
  trees[i]:photosynthesise()
  trees[i]:lose_leaves()
  
  if(trees[i].tree_type == "deciduous") then
    trees[i]:attract_wildlife()
  end

  if(trees[i].tree_type == "coniferous") then
    trees[i]:collapse()
  end
end

-- tree_3 = Deciduous_tree.new("red", "apple")
-- tree_3:photosynthesise()
-- tree_3:lose_leaves()
-- tree_3:attract_wildlife()

-- tree_4 = Deciduous_tree.new("orange", "maple")
-- tree_4:photosynthesise()
-- tree_4:lose_leaves()
-- tree_4:attract_wildlife()

-- tree_5 = Coniferous_tree.new("brown", "pine", "forrest", 2)
-- tree_5:photosynthesise()
-- tree_5:lose_leaves()
-- tree_5:collapse()

-- tree_6 = Coniferous_tree.new("green", "Spruce", "park", 7)
-- tree_6:photosynthesise()
-- tree_6:lose_leaves()
-- tree_6:collapse()
