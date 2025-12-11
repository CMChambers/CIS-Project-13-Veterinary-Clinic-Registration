using System;

namespace CIS207.Project13VeterinaryClinicRegistration
{
    public class Bird : Animal
    {
        public int WingSpan
        { get; set; }

        public override string Species
        { get; set; }


        public Bird(string name, int age) : base(name, age, "Bird")
        { }



        public override void MakeSound()
        { Console.WriteLine("Tweet."); }

        public override void PrintSpecificInfo()
        { Console.WriteLine($"Wing Span: {WingSpan} inches."); }

        public override void MakeSpecificAction()
        { Fly(); }

        public void Fly()
        { Console.WriteLine($"{Name} is flying."); }

    }
}


