namespace Fauna;

public abstract class Animal : Creature
{
	public Animal()
	{
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine("Animal was created!");
		Console.ResetColor();
	}

	public Animal(string name)
	{
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine($"Animal with name {name} was created!");
		Console.ResetColor();
		Name = name;
	}

	public override void Move()
	{
		Console.WriteLine("Animal is moving");
	}

	public void Run()
	{
		Console.WriteLine($"Animal is running");
	}

	protected override void Breath()
	{
		Console.WriteLine("Animal is breathing with air");
	}
}
