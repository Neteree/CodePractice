using System;


class Program
{	
   private static bool IsTriangle(int a, int b, int c)
    {
      return a + b > c && a + c > b && b + c > a;   
    }
    
    static void Main()
    {
		Console.WriteLine(IsTriangle(1,2,2));
		Console.WriteLine(IsTriangle(4,2,3));
		Console.WriteLine(IsTriangle(2,2,2));
		Console.WriteLine(IsTriangle(1,2,3));
		Console.WriteLine(IsTriangle(0,2,3));
		Console.WriteLine(IsTriangle(1,2,9));
    }
}
