﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_inheritance.Animals
{
    internal class Animal
    {
        // all animals have names, teeth, legs and can fly or live in water
        public string Name { get; set; }
        public int AmountTeeth { get; set; }
        public int AmountLegs { get; set; }
        public bool CanFly { get; set; }
        public bool LivesInWater { get; set; }
                
        // constructor: all animals have 20 teeth, other properties will need to be filled
        public Animal(string name, int amountLegs, bool canFly, bool livesInWater)
        {
            Name = name;
            AmountLegs = amountLegs;
            CanFly = canFly;
            LivesInWater = livesInWater;
            AmountTeeth = 20; 
        }

        //some common methods for all animals: they eat
        public void Eat()
        {
            Console.WriteLine("Nomnomnom");
        }

        // they can show their teeth
        public void ShowTeeth()
        {
            Console.WriteLine($"And then {Name} showed all its {AmountTeeth} teeth");
        }

        // there is a comprehensive education system in the zoo to teach any animal fly
        public void LearnToFly()
        {
            if (CanFly)
            {
                Console.WriteLine("wtf, I can fly already");
            }
            else
            {
                CanFly = true;
                Console.WriteLine("wooooooooooooooooo I can flyyyyyy");
            }
        }

        // some animals have escaped the zoo in the past
        public bool TryToEscapeZoo()
        {
            Random lotteryTime = new Random();
            int canItEscape = lotteryTime.Next(10);
            return canItEscape == 6; //only lucky ones succeed
        }

        // the main MakeSound-method if not overriden
        public virtual void MakeSound()
        {
            Console.WriteLine("tuuturutu i can be anyone!");
        }

    }

}
