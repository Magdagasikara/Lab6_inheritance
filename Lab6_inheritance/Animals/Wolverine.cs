using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_inheritance.Animals
{
    internal class Wolverine : Animal
    {
        public int Hunger { get; set; }

        public Wolverine(string name):base(name,4,false,false)
        {
            Hunger = 10;
            Name = name;
        }

        public new void Eat()
        {
            Console.WriteLine("This was nummy, but one day I will catch YOUUUUU!");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("(i dont think you will ever hear me!)");
        }

    }
}
