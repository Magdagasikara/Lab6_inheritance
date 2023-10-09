using Lab6_inheritance.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_inheritance.Humans
{
    internal class Human
    {   
        // even humans have names. They can also be employed or visiting the zoo
        public string Name { get; set; }
        public bool Employee { get; set; }
        public bool Visitor { get; set; }

        // constructor. if the humans is not employed, she/he is visiting the zoo
        public Human(string name, bool employee)
        {
            Name = name;
            Employee = employee;
            Visitor = Employee ? false : true;
        }

        // humans like to pet animals
        public void Pet(Animal animal)
        {
            Console.WriteLine($"Here you go, you cute {animal.GetType().Name} (scratch scratch)");
        }

        // even humans make sounds
        public void MakeSound()
        {
            Console.WriteLine("Ett - två - tre. Hallå. Hallå. Ett - två. Hallå!");
        }
    }
}
