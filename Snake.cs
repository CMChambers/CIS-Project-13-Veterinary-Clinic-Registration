using System;

namespace CIS207.Project13VeterinaryClinicRegistration
{
    public class Snake : Animal
    {
        public bool IsVenomous
        { get; set; } = false;

        public override string Species
        { get; set; }


        public Snake(string name, int age) : base(name, age, "Snake")
        { }



        public override void MakeSound()
        { Console.WriteLine("Hiss"); }

        public override void PrintSpecificInfo()
        { Console.WriteLine($"Is Venomous: {IsVenomous}"); }

        public override void MakeSpecificAction()
        { ShedSkin(); }

        public void ShedSkin()
        { Console.WriteLine($"{Name} is shedding its skin."); }

    }
}


