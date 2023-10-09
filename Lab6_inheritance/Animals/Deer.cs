using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_inheritance.Animals
{
    internal class Deer : Animal
    {   
        // a unique property for deer
        public string Color { get; set; }

        // constructor: always 4 legs, cant fly, doesnt live in water
        public Deer(string color, string name) : base(name, 4, false, false)
        {
            Color = color;
        }

        // you need to be careful as a deer
        public bool SurvivedAHunt()
        {
            return Name[1] == 'o' || Name[1] == 'a';
        }

        // a typical deer sound
        public override void MakeSound()
        {
            Console.WriteLine("Khhhh!");
        }

    }
}
