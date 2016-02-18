using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Decorator
{
    abstract class Decorator : IElement
    {
        public IElement Element { get; set; }
        public Decorator(IElement Element)
        {
            this.Element = Element;
        }
        public virtual void Display()
        {
            this.Element.Display();
        }
    }
}
