namespace Fauna;

public class Chicken : Bird
{
    public Chicken(string name, int speed) : base(name, speed)
    {
        this.Name= name;
        this.Speed= speed;
        //Console.ForegroundColor = ConsoleColor.Green;
        //Console.WriteLine("Chicken was created!");
        //Console.ResetColor();
    }
}