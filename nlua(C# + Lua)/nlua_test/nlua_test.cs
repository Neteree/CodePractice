using NLua;

Lua state = new Lua();
string functionsLuaFile = File.ReadAllText(@"./functions.lua");
state.DoString(functionsLuaFile);

var greet = state["greet"] as LuaFunction;
var printNTimes = state["print_n_times"] as LuaFunction;
var printSum = state["print_sum"] as LuaFunction;
var printDifference = state["print_difference"] as LuaFunction;
var printProduct = state["print_product"] as LuaFunction;
var printQuotient = state["print_quotient"] as LuaFunction;
var getSum = state["get_sum"] as LuaFunction;
var getDifference = state["get_difference"] as LuaFunction;
var getProduct = state["get_product"] as LuaFunction;
var getQuotient = state["get_quotient"] as LuaFunction;

greet?.Call();
printNTimes?.Call(3);
printSum?.Call(1, 2);
printDifference?.Call(1, 2);
printProduct?.Call(1, 2);
printQuotient?.Call(1, 2);
Console.WriteLine(getSum?.Call(4, 3).First());
Console.WriteLine(getDifference?.Call(4, 3).First());
Console.WriteLine(getProduct?.Call(4, 3).First());
Console.WriteLine(getQuotient?.Call(4, 3).First());