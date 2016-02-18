using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Decorator
{
    class FanClub : Decorator
    {
        public List<string> Fans { get; protected set; } = new List<string>();
        public FanClub(IElement Element) : base(Element)
        {
        }
        public void Enroll(string Fan)
        {
            this.Fans.Add(Fan);
        }
        public override void Display()
        {
            Console.WriteLine("Ladies and gentlemen, let me present this article : ");
            base.Display();
            this.Fans.ForEach(fan => Console.WriteLine($"{fan} is falling love with {this.Element}"));
        }
    }
}
