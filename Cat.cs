using System;

namespace CIS207.Project13VeterinaryClinicRegistration
{
    public class Cat : Animal
    {
        public bool IsIndoor
        { get; set; } = true;

        public override string Species
        { get; set; }

        //public override string UniqueProperty
        //{
        //    get { return Breed; }
        //    set { Breed = value; }
        //}

        public Cat(string name, int age) : base(name, age, "Cat")
        { }



        public override void MakeSound()
        { Console.WriteLine("Meow"); }

        public override void PrintSpecificInfo()
        { Console.WriteLine($"Is Indoor: {IsIndoor}"); }

        public override void MakeSpecificAction()
        { Scratch(); }

        public void Scratch()
        { Console.WriteLine($"{Name} is scratching."); }

    }
}


