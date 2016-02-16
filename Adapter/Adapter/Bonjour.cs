using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Bonjour : IBonjour
    {
        private FrenchSpeaker _fspk;
        public void SayHi(string name)
        {
            this._fspk = new FrenchSpeaker(name);
            this._fspk.Greeting();
        }
    }
}
