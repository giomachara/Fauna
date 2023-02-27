namespace Fauna;

public class Spider : Insect
{
    public Spider(string name) : base(name)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Spider was created!");
        Console.ResetColor();
    }
}