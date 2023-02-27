namespace Fauna;

public abstract class Creature : Comparable
{
    //public Creature()
    //{
    //    Console.ForegroundColor = ConsoleColor.Green;
    //    Console.WriteLine("Creature was created!");
    //    Console.ResetColor();
    //    Breath();
    //}

    public int Weight { get; set; }

    public int Speed { get; set; }

    public string Name { get; set; }

    public virtual void Move()
    {
        Console.WriteLine("Creature is moving");
    }

    public override string ToString()
    {
        return this.Name;
    }
    protected abstract void Breath();

    public override int CompareTo(object obj)
    {
        Creature x = (Creature)obj;


        if (obj is Animal)
        {
            return this.Weight.CompareTo(x.Weight);
        }

        if (obj is Bird)
        {
            return this.Speed.CompareTo(x.Speed);
        }

        return 0;
    }
}
