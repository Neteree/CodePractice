using System;

public class Program
{
	public static int CountVowels(string str)
    	{
    		str = str.ToLower();
    		int vowelCount = 0;
        
		foreach(char c in str)
	        {
	       		if(c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u') {
	            		vowelCount++;
	        	}
	        }
        
        	return vowelCount;
	}

	public static void Main()
	{
		int vowelCount = CountVowels("I would like a flat white please. Also, one croissant please.");
		Console.WriteLine(vowelCount);
	}
}
