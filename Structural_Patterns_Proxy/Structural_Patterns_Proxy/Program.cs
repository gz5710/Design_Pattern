using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Patterns_Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker worker = new GoodWorker();
            worker.DoWork();
            IWorker lazyworker = new LazyWorker();
            lazyworker.DoWork();
            Console.ReadKey();
        }
    }
}
