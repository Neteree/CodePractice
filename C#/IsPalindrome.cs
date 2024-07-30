using System;

class Program
{
	private static bool IsPalindrome(int xInt) {
        
        	string xStr = xInt.ToString();
		string reversedXStr = "";

	        for(int i = xStr.Length - 1; i >= 0; i--)
	        {
	            reversedXStr += xStr[i];
	        }
	
	        return xStr == reversedXStr;
	}
	
	
	static void Main()
	{
		Console.WriteLine(IsPalindrome(121));
		Console.WriteLine(IsPalindrome(-121));
		Console.WriteLine(IsPalindrome(10));
	}
}
