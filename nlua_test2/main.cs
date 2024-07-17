using NLua;

Lua state = new Lua();
string mainLuaFile = File.ReadAllText(@"./main.lua");
state["c_sharp_methods_obj"] = new CSharpMethods();
state.DoString(mainLuaFile);



class CSharpMethods
{
    public string trim(string str) => str.Trim();
	
	public int length(string[] arr) => arr.Length; 
	public string[] split(string str, string delimiter) => str.Split(delimiter);
	public double clamp(double value, double min, double max) => Math.Clamp(value, min, max);
}