using System;

public class Program
{
	private static Func<int, Func<int>> createOscillator = (int amplitude) => {
    		int currentValue = -1;
			int incrementAmount = 1;
			
    		return () => {
			if(Math.Abs(currentValue) >= amplitude) { 
				incrementAmount = -incrementAmount;
			}
				 
			return currentValue += incrementAmount;
		};
	};

	public static void Main()
	{
		var oscillator_amplitude2 = createOscillator(2);
		var oscillator_amplitude3 = createOscillator(3);
	
		for(int i = 0; i < 9; i++) {
			Console.WriteLine(oscillator_amplitude2());
		}
		
		for(int i = 0; i < 13; i++) {
			Console.WriteLine(oscillator_amplitude3());
		}
		
	}
}
