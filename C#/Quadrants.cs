class Program
{
	public static int Quadrant(int x, int y)
  	{
		if(x > 0 && y < 0)
		{
		  return 4;
		}
		else if(x < 0 && y < 0)
		{
		  return 3;
		}
		else if(x < 0 && y > 0)
		{
		  return 2;
		}
		else
		{
		  return 1;
		}
	}
	
    static void Main()
    {
  		Console.WriteLine(Quadrant(1, 1));
  		Console.WriteLine(Quadrant(-1, 1));
  		Console.WriteLine(Quadrant(-1, -1));
  		Console.WriteLine(Quadrant(1, -1));
    }
}
