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
        public string Name { get; set; }
        public bool Employee { get; set; }
        public bool Visitor { get; set; }

        public Human(string name, bool employee)
        {
            Name = name;
            Employee = employee;
            Visitor = Employee ? false : true;
        }

        public void Pet(Animal animal)
        {
            Console.WriteLine($"Here you go, you cute {animal.GetType().Name} (scratch scratch)");
        }
        public void MakeSound()
        {
            Console.WriteLine("Ett - två - tre. Hallå. Hallå. Ett - två. Hallå!");
        }
    }
}
