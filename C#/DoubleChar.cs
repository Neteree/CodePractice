using System;

class Program
{	public static string DoubleChar(string str)
	{
		string resultant_str = "";

		foreach(char ch in str)
		{
		  resultant_str += $"{ch}{ch}";
		}

		return resultant_str;
  	}
 
    static void Main()
    {
  		Console.WriteLine(DoubleChar("abcd"));
  		Console.WriteLine(DoubleChar("Adidas"));
  		Console.WriteLine(DoubleChar("illuminati"));
  		Console.WriteLine(DoubleChar("123456"));
  		Console.WriteLine(DoubleChar("abcd"));
  		Console.WriteLine(DoubleChar("%^&*("));
    }
}
