using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_inheritance.Animals
{
    internal class Reindeer : Deer
    {
        public Reindeer(string name) : base("grey", name)
        {
        }
        public override void MakeSound()
        {
            Console.WriteLine("Jingle bells, jingle bells, it is reindeer time!");
        }

    }
}
