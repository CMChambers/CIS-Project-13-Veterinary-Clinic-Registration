using System;

namespace CIS207.Project13VeterinaryClinicRegistration
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animalsFromFile = new List<Animal>();
            // object instantiation
            Dog dog = new Dog("Buddy", 3);
            Cat cat = new Cat("Whiskers", 2);
            Bird bird = new Bird("Polly", 1);
            Snake snake = new Snake("Mr Slithers", 4);

            List<Animal> animals = new List<Animal>();

            animals.Add(dog);
            animals.Add(cat);
            animals.Add(bird);
            animals.Add(snake);

            foreach (var animal in animals)
            {
                // test shared properties
                animal.PrintBasicInfo();
                // test shared methods
                animal.MakeSound();
                // test unique properties
                //animal.PrintSpecificInfo();
                // test unique methods
                // animal.MakeSpecificAction();
                Console.WriteLine();
            }

            dog.Fetch();
            cat.Scratch();
            bird.Fly();
            snake.ShedSkin();

        }
    }
}
