using System;

class Program
{
	public static string WhatDay(int n)
  	{
    	if(n < 1 || n > 7)
    	{
        	return "Wrong, please enter a number between 1 and 7";
    	}
    
		string[] days = {
		  "Sunday",
		  "Monday",
		  "Tuesday",
		  "Wednesday",
		  "Thursday",
		  "Friday",
		  "Saturday",

		};
    
    	return days[n - 1];
  	}
	
    static void Main()
    {
  		for(int n = 0; n <= 8; n++)
  		{
  			Console.WriteLine(WhatDay(n));
  		}
    }
}
