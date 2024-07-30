using System;

class Program
{
	public static int[] TwoSum(int[] nums, int target) {
		int[] output = [];

		for(int i = 0; i < nums.Length; i++)
		{
			for(int j = i + 1; j < nums.Length; j++)
			{
				if(nums[i] + nums[j] == target) {
					output = [i, j];
				}
			}
		}

		return output;
	}
	
    static void Main()
    {
		int[][] outputs = [
			TwoSum([2,7,11,15], 9),
			TwoSum([3,2,4], 6),
			TwoSum([3,3], 6)
		];
		
		for(int i = 0; i < outputs.Length; i++)
		{
			Console.WriteLine($"Output {i}: [{outputs[i][0]}, {outputs[i][1]}]");
		}
    }
}
