using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Italianchef : Chef
    {
        public override void specialDish()
        {
            Console.WriteLine("i can make special bbq ribs.");
        }
    }
}
