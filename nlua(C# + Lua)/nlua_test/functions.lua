function greet()
	io.write("Hi! What's your name? ")
	local name = io.read()
	print("Nice to meet you " .. name)
end

function print_n_times(n)
	for i = 1, n do
		print(i)
	end
end

function print_sum(a, b)
	print(a + b)
end

function print_difference(a, b)
	print(a - b)
end

function print_product(a, b)
	print(a * b)
end

function print_quotient(a, b)
	print(a / b)
end

function get_sum(a, b)
	return a + b
end

function get_difference(a, b)
	return a - b
end


function get_product(a, b)
	return a * b
end


function get_quotient(a, b)
	return a / b
end

