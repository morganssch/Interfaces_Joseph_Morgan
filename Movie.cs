using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Joseph_Morgan
{
    internal class Movie : IGenre
    {
        public string ESRB { get; set; }
        public string Genre { get; set; }
        public string Title { get; set; }

        public Movie(string genre, string esrb, string title)
        {
            Genre = genre;
            ESRB = esrb;
            Title = title;
        }

        public void PlayMovie()
        {
            Console.WriteLine($"Movie is Starting, Ssssshhhhhh");
        }

        public string describe()
        {
            return $"The movie {Title} is a {Genre} film with an ESRB rating of {ESRB}";
        }
    }
}
