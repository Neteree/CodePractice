using System;

class Program
{	
  public static long[] Digitize(long n)
	{
		string nString = n.ToString();
		long[] digits = new long[nString.Length];
		
		for(int i = 0; i < nString.Length; i++)
		{
			digits[i] = long.Parse(nString[i].ToString());
		}
		
		Array.Reverse(digits);
      
		return digits;
  }
  
    
    static void Main()
    {
		  long[] digits = Digitize(123456789);
		
  		foreach(long digit in digits)
  		{
  			Console.WriteLine(digit);
  		}
    }
}
