using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Decorator
{
    class Film : IElement
    {
        public string Name { get; set; }
        public string Director { get; set; }
        public Film(string Name, string Director)
        {
            this.Name = Name;
            this.Director = Director;
        }
        public void Display()
        {
            Console.WriteLine($"This is a Film, named {this.Name}, directed by {this.Director}");
        }
        public override string ToString()
        {
            return this.Name;
        }
    }
}
