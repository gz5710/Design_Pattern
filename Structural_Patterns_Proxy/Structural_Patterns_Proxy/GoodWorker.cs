using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Patterns_Proxy
{
    class GoodWorker : IWorker
    {
        public void DoWork()
        {
            Console.WriteLine("Good worker has done this job.");
        }
    }
}
