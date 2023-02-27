namespace Fauna;

public class Vehicle
{
    public Vehicle(string type)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Vehicle was created!");
        Console.ResetColor();
    }
}