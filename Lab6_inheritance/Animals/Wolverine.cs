using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_inheritance.Animals
{
    internal class Wolverine : Animal
    {
        // wolverines might be hungry 1-10
        public int Hunger { get; set; }

        // constructor. wolverines are usually hungry=10
        public Wolverine(string name):base(name,4,false,false)
        {
            Hunger = 10;
            Name = name;
        }

        // they can eat. use the "new" keyword to override the animals' method
        public new void Eat()
        {
            Console.WriteLine("This was nummy, but one day I will catch YOUUUUU!");
        }

        // they try to make a sound
        public override void MakeSound()
        {
            Console.WriteLine("(if you ever hear me, it's too late!)");
        }

    }
}
