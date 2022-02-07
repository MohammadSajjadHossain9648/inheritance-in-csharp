using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Chef
    {
        public void makeChicken()
        {
            Console.WriteLine("i can make chicken.");
        }
        public void makeBurger()
        {
            Console.WriteLine("i can make burger.");
        }
        public virtual void specialDish() 
        {
            Console.WriteLine("i can make special bbq rice.");
        }
    }
}
