using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Patterns_Flyweight
{
    public class ConcreteFlyweight : Flyweight
    {
        public override void ShowID()
        {
            Console.WriteLine(this.GetHashCode());
        }
    }
}
