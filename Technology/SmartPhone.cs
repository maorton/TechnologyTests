using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class SmartPhone : Computer
    {
        public List<string> functions = new List<string> {"Call", "Text", "Browse internet"};

        public SmartPhone(string name, double ram, double weight) : base(name, ram, weight)
        {

        }
        
    }

}
