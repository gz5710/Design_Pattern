using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Decorator
{
    class SuperFanClub : FanClub
    {
        public SuperFanClub(IElement Element) : base(Element)
        {
            this.Fans = new List<string>();
        }
    }
}
