using System;

class Program
{
	public static string Problem(String input)
  	{
		bool isNumerical = double.TryParse(input, out double myDouble);
    
		if(isNumerical)
		{
		  return (myDouble * 50 + 6).ToString();
		}

		  return "Error";
  	}
	
    static void Main()
    {
  		Console.WriteLine(Problem("hello"));
  		Console.WriteLine(Problem("1"));
  		Console.WriteLine(Problem("5"));
  		Console.WriteLine(Problem("0"));
  		Console.WriteLine(Problem("1.2"));
    }
}
