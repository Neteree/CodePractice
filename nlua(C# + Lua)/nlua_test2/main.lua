local my_string = "      Hello world!!!    "
local my_string_2 = "apple,banana,orange"

print(c_sharp_methods_obj:trim(my_string))
local fruit_array = c_sharp_methods_obj:split(my_string_2, ",")
print(c_sharp_methods_obj:length(fruit_array))

for i = 0, c_sharp_methods_obj:length(fruit_array) - 1 do
    print(fruit_array[i])
end

print(c_sharp_methods_obj:clamp(0, 1, 2))
print(c_sharp_methods_obj:clamp(3, 1, 2))