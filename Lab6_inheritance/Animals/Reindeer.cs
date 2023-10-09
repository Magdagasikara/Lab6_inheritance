using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_inheritance.Animals
{
    internal class Reindeer : Deer
    {
        // questionnable properties
        public bool IsCute { get; set; }
        public bool TastesGood {  get; set; }

        // constructor with non questionnable default values
        public Reindeer(string name) : base("grey", name)
        {
            IsCute = true;
            TastesGood = true;

        }

        // everyone knows how a reindeer sounds
        public override void MakeSound()
        {
            Console.WriteLine("Jingle bells, jingle bells, it is reindeer time!");
        }

    }
}
