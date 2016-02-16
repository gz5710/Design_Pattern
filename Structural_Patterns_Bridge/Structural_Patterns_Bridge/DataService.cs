using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Patterns_Bridge
{
    public class MysqlService : IService
    {

        public void DoWork()
        {
            Console.WriteLine("Hi, we're storing data in mysql, finishing in a moment.");
        }
    }
}
