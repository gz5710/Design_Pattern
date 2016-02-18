using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Decorator
{
    class Book : IElement
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public Book(string Name, string Author)
        {
            this.Name = Name;
            this.Author = Author;
        }
        public void Display()
        {
            Console.WriteLine($"This book[{this.Name}] was wrote by {this.Author}");
        }
        public override string ToString()
        {
            return this.Name;
        }
    }
}
