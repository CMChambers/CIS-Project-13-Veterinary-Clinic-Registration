
namespace CIS207.Project13VeterinaryClinicRegistration
{
    abstract public class Animal
    {
        public string Name { get; set; }

        public int Age { get; set; }

        abstract public string Species { get; set; }

        //public abstract string UniqueProperty { get; set; }


        public Animal(string name, int age, string species)
        {
            Name = name;
            Age = age;
            Species = species;
        }


        public abstract void MakeSound();
        public abstract void PrintSpecificInfo();
        public abstract void MakeSpecificAction();

        public void PrintBasicInfo()
        { System.Console.WriteLine($"Name: {Name}, Age: {Age}, Species: {Species}"); }
    }
}


