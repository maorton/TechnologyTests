using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace Technology
{
    public abstract class Computer
    {
        public string Name;
        public readonly double Ram;
        public double Weight;
        public static int nextComputerID = 1;
        private readonly int ComputerID;

        public Computer(string name, double ram, double weight)
        {
            Name = name;
            Ram = ram;
            Weight = weight;
        }

        public Computer(string name)
        {
            Name = name;
            ComputerID = nextComputerID;
            nextComputerID++;
            Ram = 0;
            Weight = 0;
        }
         public string ComputerRAM()
        {
            return (Name + " has " + Ram + " gb of RAM.");
        }
         public string ComputerWeight()
        {
            return (Name + " weighs " + Weight + " lbs.");
        }
    }
}
