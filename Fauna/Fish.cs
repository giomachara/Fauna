namespace Fauna;

public class Fish : Creature
{
    public Fish(string name)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Fish was name {name} created!");
        Console.ResetColor();
    }

    public void Swim()
    {
        Console.WriteLine($"Fish is swimming");
    }

    public override void Move()
    {
        Console.WriteLine("Fish is moving");
    }

    protected override void Breath()
    {
        Console.WriteLine("Fish is breathing in water");
    }
}