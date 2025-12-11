using System;

namespace CIS207.Project13VeterinaryClinicRegistration
{
    public class Dog : Animal
    {
        public string Breed
        { get; set; }

        public override string Species
        { get; set; }

        //public override string UniqueProperty
        //{
        //    get { return Breed; }
        //    set { Breed = value; }
        //}


        public Dog(string name, int age) : base(name, age, "Dog")
        { }



        public override void MakeSound()
        { Console.WriteLine("Woof! Woof!"); }

        public override void PrintSpecificInfo()
        { Console.WriteLine($"Breed: {Breed}"); }

        public override void MakeSpecificAction()
        { Fetch(); }

        public void Fetch()
        { Console.WriteLine($"{Name} is fetching the ball."); }
    }
}


