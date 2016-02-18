using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IElement book = new Book("《红楼梦》", "曹雪芹");
            book.Display();

            IElement film = new Film("Rush Hour", "Jacky CHEN");
            film.Display();

            FanClub club = new FanClub(film);
            club.Enroll("Lucy");
            club.Enroll("Lily");
            club.Enroll("Jim");
            club.Enroll("Tom");
            club.Display();

            Console.ReadKey();
        }
    }
}
