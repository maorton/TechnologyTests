using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class Laptop : Computer
    {
        public bool IsMobile { get; set; }

        public Laptop(string name) : base(name) { }
        public Laptop(string name, double ram, double weight) : base (name, ram, weight)
        {
        }

        public bool Mobile()
        {
            IsMobile = true;
            return IsMobile;
        }
    }
}
