using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Joseph_Morgan
{
    internal interface IGenre // Define an interface named IGenre
    {
        string ESRB { get; set; } // Property for ESRB rating
        string Genre { get; set; } // Property for genre type
        string Title { get; set; } // Property for title of the game or movie

        string describe(); // Method to describe the game or movie, returns a string
    }
}
