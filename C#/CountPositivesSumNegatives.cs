using System;
using System.Linq;

class Program
{	
	private static int[] CountPositivesSumNegatives(int[] input)
	{
		if(input == null || input.Length == 0)
		{
			return Array.Empty<int>();
		}
        
		return new int[]
		{
			input.Count(i => i > 0),
			input.Sum(i => i < 0 ? i : 0)
		};
	}
    
	static void Main()
  {
		int[] intArr = {-1,1,-2,2};
		int[] CountPositivesSumNegativesArr = CountPositivesSumNegatives(intArr);
		
		Console.WriteLine($"Counted Positives: {CountPositivesSumNegativesArr[0]}");
		Console.WriteLine($"Summed Negatives: {CountPositivesSumNegativesArr[1]}");
  }
}
