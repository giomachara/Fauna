namespace Fauna;

    public class Bee : Insect
    {
	    public Bee(string name) : base(name)
	    {
		    Console.ForegroundColor = ConsoleColor.Green;
		    Console.WriteLine("Bee was created!");
		    Console.ResetColor();
	    }
	}
