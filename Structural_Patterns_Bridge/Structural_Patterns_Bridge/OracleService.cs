using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Patterns_Bridge
{
    class OracleService : IService
    {
        public void DoWork()
        {
            Console.WriteLine("Haha, this is Oracle.");
        }
    }
}
