using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_inheritance.Animals
{
    internal class Elk : Deer
    {
        public Elk(string name) : base("brown", name)
        {
        }
    }
}
