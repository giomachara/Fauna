namespace Fauna;

public class Car : Vehicle
{
    public Car(string model) : base(model)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Car was created!");
        Console.ResetColor();
    }
}