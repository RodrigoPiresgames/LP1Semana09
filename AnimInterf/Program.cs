using System;

namespace AnimInterf
{
    class Program
    {
        Animal[] Animal_Array = new Animal[10];
        static async void Main(string[] args)
        {
            int num;

            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                num = rnd.Next(0, 4);
                switch(num)
                {
                    case 0:
                        Animal_Array[i] = new Bat();
                        break;
                    case 1:
                        Animal_Array[i] = new Bee();
                        break;
                    case 2:
                        Animal_Array[i] = new Cat();
                        break;
                    case 3:
                        Animal_Array[i] = new Dog();
                        break;
                }
            }

            DoTheThing(Animal_Array);

        }
    }

    public void DoTheThing(Animal_Array)
    {
        foreach(Animal animal in Animal_Array)
        {
            Console.WriteLine(animal.Sound());
            if (animal is IMammal)
            {
                Console.WriteLine(animal.NumberOfNipples());
            }
            if (animal is IFly)
            {
                Console.WriteLine(animal.NumberOfWings());
            }
        }
    }
}
