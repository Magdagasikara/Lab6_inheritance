using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_inheritance.Animals
{
    internal class Elk : Deer
    {
        // a questionable property
        public bool IsCute {  get; set; }

        // .. with a questionable setting in the constructor
        public Elk(string name) : base("brown", name)
        {
            IsCute = false;
        }
        
        // life is tough (this kind of method should probably be in the humans' class but I didn't come up with a better one for elks)
        public void DriveToExtinction()
        {
            Console.WriteLine("E, guys! Elks destroy my forest. Let's go hunting!");
        }

        // elks have no own MakeSound-method, they have to inherit their sound

    }
}
