using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class FrenchSpeaker
    {
        private readonly string _name;

        public FrenchSpeaker(string name)
        {
            this._name = name;
        }

        public void Greeting()
        {
            Console.WriteLine($"{_name}, nice to meet you.");
        }
    }
}
