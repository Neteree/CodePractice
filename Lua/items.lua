local Item = {}
Item.__index = Item

Item.new = function(name, price, description)
  local instance = setmetatable({}, Item)
  
  instance.get_name = function()
    return name
  end
  
  instance.get_price = function()
    return price
  end
  
  instance.get_description = function()
    return description
  end
  
  instance.set_name = function(_name)
    name = _name
  end
  
  instance.set_price = function(_price)
    price = _price
  end
  
  instance.set_description = function(_description)
    description = _description
  end
  
  instance.display_info = function()
    print()
    print("Name: " .. name)
    print("Price: " .. price)
    print("Description: " .. description)
  end
  
  return instance
end

local items = {
 Item.new("book", 2.25, "a dusty old book"),
 Item.new("gem", 100, "a sparkly gem"),
 Item.new("cake", 5.45, "a delicious looking piece of cake"),
}

local total_price = 0
for i = 1, #items do
  print(items[i].display_info())
end

items[1].set_name("tomb")
print(items[1].get_name())

items[2].set_price(50)
print(items[2].get_price())

items[3].set_description("a dry looking piece of cake")
print(items[3].get_description())
