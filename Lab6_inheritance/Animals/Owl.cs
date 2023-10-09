using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_inheritance.Animals
{
    internal class Owl : Animal
    {
        public bool CanSoundHoho { get; set; }

        public Owl(string name) : base(name, 2, true, false)
        {
            CanSoundHoho = true;
        }
        public void AttackAnimal(Animal animal)
        {
            Random random = new Random();
            int fate = random.Next(4);
            if (fate == 1)
            {
                Console.WriteLine($"{animal.Name} is too dangerous to be attacked!");
            }
            else if (fate == 2)
            {
                Console.WriteLine("And what an epic fight it was!");
            }
            else
            {
                Console.WriteLine($"RIP {animal.Name}. 12.04.1983 - {DateTime.Today.ToString("dd/MM/yyyy")}");
            }

        }
        public override void MakeSound()
        {
            Console.WriteLine("Ho hoooooooo");
        }

    }
}
