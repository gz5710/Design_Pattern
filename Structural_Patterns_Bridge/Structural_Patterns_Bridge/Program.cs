using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Patterns_Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager magr = new DataManager("Bruce");

            magr.CreateService(new MysqlService());
            magr.UserService();
            magr.DisposeService();

            magr.CreateService(new OracleService());
            magr.UserService();
            magr.DisposeService();

            Console.ReadKey();
        }
    }
}
