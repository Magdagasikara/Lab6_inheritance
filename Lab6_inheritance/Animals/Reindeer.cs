using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_inheritance.Animals
{
    internal class Reindeer : Deer
    {
        public bool IsCute { get; set; }
        public bool TastesGood {  get; set; }


        public Reindeer(string name) : base("grey", name)
        {
            IsCute = true;
            TastesGood = true;

        }
        public override void MakeSound()
        {
            Console.WriteLine("Jingle bells, jingle bells, it is reindeer time!");
        }

    }
}
