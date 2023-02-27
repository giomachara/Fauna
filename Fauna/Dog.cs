namespace Fauna;

public class Dog : Animal
{
	public Dog() : base("Dog")
	{
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine("Dog was created!");
		Console.ResetColor();
	}

	public Dog(string name, int weight)
	{
		this.Name= name;
		this.Weight = weight;
		Console.ForegroundColor = ConsoleColor.Green;
		Console.WriteLine($"Dog with name {name} was created!");
		Console.ResetColor();
	}

    public override string ToString()
    {
        return $"{Name}-{Weight}";
    }

    public override void Move()
    {
        Console.WriteLine("Dog is moving");
    }

    public void Bark()
	{
		Console.WriteLine($"{Name} is barking");
	}

	protected /*sealed*/ override void Breath()
	{
		base.Breath();
		Console.WriteLine("Dog is breathing with air");
	}
}