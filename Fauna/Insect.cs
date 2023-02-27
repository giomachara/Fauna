namespace Fauna;

public class Insect : Creature
{
    public Insect(string name)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Insect with name {name} was created!");
        Console.ResetColor();
    }

    protected override void Breath()
    {
        Console.WriteLine("Insect is breathing with air");
    }
}