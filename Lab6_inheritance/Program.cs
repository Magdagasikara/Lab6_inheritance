﻿using Lab6_inheritance.Animals;
using Lab6_inheritance.Humans;

namespace Lab6_inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create some animals and a human, animals have default properties of their species and i just add names
            Wolverine rosomak = new Wolverine("Djärving");
            Reindeer rudolf = new Reindeer("Rudolf");
            Elk elk = new Elk("Damoouse");
            Owl greyowl = new Owl("Oogle");
            Human magda = new Human("Magda", false);
            // nobody knows species of this one
            Animal newcomer = new Animal("Herr Disaster", 3, false, false);
            Console.WriteLine("------------------");

            // can you pet a wolverine?
            magda.Pet(rosomak);
            magda.Pet(newcomer);
            Console.WriteLine("------------------");

            // animals make sounds with overriden methods
            Console.Write("wolverine says: "); 
            rosomak.MakeSound();
            Console.Write("owl says: ");
            greyowl.MakeSound();
            Console.Write("reindeer says: ");
            rudolf.MakeSound();
            Console.Write("elk says: ");
            elk.MakeSound(); // he gets the universal deer sound, no override for elks
            Console.Write("magda says: ");
            magda.MakeSound();
            // animal makes a sound with the base method
            Console.Write("animal says: ");
            newcomer.MakeSound();
            Console.WriteLine("------------------");

            // can you teach them fly?
            Console.Write($"The moose is being taught to fly: "); elk.LearnToFly();
            Console.Write($"Grey owl is being taught to fly: "); greyowl.LearnToFly();
            Console.WriteLine("------------------");

            // can they make it after being attacked
            Console.Write($"Grey owl attacked a wolverine: "); greyowl.AttackAnimal(rosomak); 
            Console.Write($"Grey owl attacked the poor animal: ");greyowl.AttackAnimal(newcomer);
            Console.WriteLine("------------------");

            // who let hunters enster the zoo?
            Console.WriteLine($"Has {rudolf.Name} survived the hunt: {rudolf.SurvivedAHunt()}");
            Console.WriteLine($"Has {elk.Name} survived the hunt: {elk.SurvivedAHunt()}");
            Console.WriteLine("------------------");

            // just to doublecheck the human's role
            Console.WriteLine($"Employee: {magda.Employee} ");
            Console.WriteLine($"Visitor: {magda.Visitor} ");
            Console.WriteLine("------------------");

        }
    }
}