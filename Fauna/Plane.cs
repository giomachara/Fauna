namespace Fauna;

public class Plane : Vehicle
{
    public Plane(string name) : base(name)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Plane was created!");
        Console.ResetColor();
    }
}