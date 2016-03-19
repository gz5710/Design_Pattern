using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Patterns_Facade
{
    class Presenter : IPresent
    {
        public void PresentData(string data)
        {
            Console.WriteLine(data);
        }
    }
}
