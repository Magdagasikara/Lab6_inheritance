using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_inheritance.Animals
{
    internal class Deer : Animal
    {
        public string Color { get; set; }

        public Deer(string color, string name) : base(name, 4, false, false)
        {
            Color = color;
        }

        public bool SurvivedAHunt()
        {
            return Name[1] == 'o' || Name[1] == 'a';
        }

        public override void MakeSound()
        {
            Console.WriteLine("Khhhh!");
        }

    }
}
