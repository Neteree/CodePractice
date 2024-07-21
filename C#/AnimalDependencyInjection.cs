using System;

public interface ISound
{
    void MakeSound();
}

public class Roar : ISound
{
    public void MakeSound()
    {
        Console.WriteLine("Roar!!!");
    }
}

public class Speak : ISound
{
    public void MakeSound()
    {
        Console.WriteLine("Blah blah blah!");
    }
}

public class Animal
{
    private readonly ISound _sound;
    
    public Animal(ISound sound)
    {
        _sound = sound;
    }
    
    public void Vocalise()
    {
        _sound.MakeSound();
    }
}

public class Program
{
	public static void Main()
	{
		Animal beast = new Animal(new Roar());
		Animal human = new Animal(new Speak());
		
		beast.Vocalise();
		human.Vocalise();
	}
}
