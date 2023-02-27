namespace Fauna;

public class Bird : Creature
{
    public  Bird()
        {
        }

    public Bird(string name, int speed)
    {
        this.Name = name;
        this.Speed = speed;
        //Console.ForegroundColor = ConsoleColor.Green;
        //Console.WriteLine($"Bird with name {name} was created!");
        //Console.ResetColor();
    }

    //public void Fly()
    //{
    //    Console.WriteLine($"Bird is flying");
    //}

    protected override void Breath()
    {
        Console.WriteLine("Bird is breathing with air");
    }

    public override string ToString()
    {
        return $"{Name}-{Speed}";
    }
}