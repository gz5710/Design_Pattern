using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Patterns_Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            FlyweightFactory factory = new FlyweightFactory();
            var flyX = factory["X"];
            if (flyX != null)
            {
                flyX.ShowID();
            }
            var flyY = factory["W"];
            if (flyY != null)
            {
                flyY.ShowID();
            }
            else
            {
                Console.WriteLine("This flyweight doesn't exist.");
            }
            Console.ReadKey();
        }
    }
}
