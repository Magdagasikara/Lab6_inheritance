using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_inheritance.Animals
{
    internal class Elk : Deer
    {
        public bool IsCute {  get; set; }
        public Elk(string name) : base("brown", name)
        {
            IsCute = false;
        }

        public void DriveToExtinction()
        {
            Console.WriteLine("E, guys! Elks destroy my forest. Let's go hunting!");
        }
    }
}
