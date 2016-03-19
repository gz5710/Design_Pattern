using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Patterns_Proxy
{
    class LazyWorker : IWorker
    {
        private GoodWorker _worker;
        public void DoWork()
        {
            Console.WriteLine($"\nLazy work got a new task.");
            if (this._worker == null)
            {
                this._worker = new GoodWorker();
            }
            this._worker.DoWork();
        }
    }
}
