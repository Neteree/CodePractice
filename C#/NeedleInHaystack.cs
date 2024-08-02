using System;

class Program
{	
	private static string FindNeedle(object[] haystack)
	{
		int index = Array.IndexOf(haystack, "needle");
		return $"found the needle at position {index}";
	}
    
	static void Main()
	{
		Console.WriteLine(FindNeedle(new object[]{'3', "123124234", null, "needle", "world", "hay", 2, '3', true, false}));	
		Console.WriteLine(FindNeedle(new object[]{"283497238987234", "a dog", "a cat", "some random junk", "a piece of hay", "needle", "something somebody lost a while ago"}));	
		Console.WriteLine(FindNeedle(new object[]{1,2,3,4,5,6,7,8,8,7,5,4,3,4,5,6,67,5,5,3,3,4,2,34,234,23,4,234,324,324,"needle",1,2,3,4,5,5,6,5,4,32,3,45,54}));	
	}
}
