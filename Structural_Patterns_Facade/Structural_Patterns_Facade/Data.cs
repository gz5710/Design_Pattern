using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Patterns_Facade
{
    class Data : IData
    {
        public string GetData()
        {
            return "Data String";
        }
    }
}
