using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Joseph_Morgan
{
    internal class Game : IGenre
    {
        public string ESRB { get; set; }
        public string Genre { get; set; }
        public string Title { get; set; }

        public Game(string genre, string esrb, string title)
        {
            Genre = genre;
            ESRB = esrb;
            Title = title;
        }

        public void PlayGame()
        {
            Console.WriteLine($"Game is Starting");
        }
        
        public string describe()
        {
            return $"The game {Title} is a {Genre} game with an ESRB rating of {ESRB}";
        }
    }
}
