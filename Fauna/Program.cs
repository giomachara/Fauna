using System;

namespace Fauna
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dog dog1 = new Dog();
            //Dog dog2 = new Dog();
            //SuperDog superDog1 = new SuperDog();
            //Cat cat1 = new Cat();
            //Shark shark1 = new Shark("Shark");

            //Console.Clear();

            //MyMove(dog1);
            //MyMove(dog2);
            //MyMove(superDog1);
            //MyMove(cat1);
            //MyMove(shark1);
            //Console.WriteLine(dog1);

            //Object x = new SuperDog();
            //x.ToString();
            //x.Move();
            //x.Run();
            //x.Bark();
            //x.Fly();

            Dog[] dogs =
                {
                new Dog ("Beni",40),
                new Dog ("Toni",10),
                new Dog ("Jeccy",35),
                new Dog ("Zoro",80),
            };

            MyTools.Sort(dogs);

            for (int i = 0; i < dogs.Length; i++)
            {
                Console.WriteLine(dogs[i]);
            }

            Bird[] birds =
              {
                new Bird ("Kvavi",55),
                new Bird ("Guguli",25),
                new Bird ("Mckeri",40),
                new Bird ("Arcivi",120),
            };

            MyTools.Sort(birds);

            for (int i = 0; i < birds.Length; i++)
            {
                Console.WriteLine(birds[i]);
            }




        }
    }
}
