using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Joseph_Morgan
{
    internal class Movie : IGenre // Movie class implements the IGenre interface
    {
        public string ESRB { get; set; } // Property for ESRB rating
        public string Genre { get; set; } // Property for genre type
        public string Title { get; set; } // Property for title of the movie

        public Movie(string genre, string esrb, string title) // Constructor to initialize the movie object with genre, ESRB rating, and title
        {
            Genre = genre; // Set the genre property
            ESRB = esrb; // Set the ESRB property
            Title = title; // Set the title property
        }

        public void PlayMovie() // Method to simulate playing the movie
        {
            Console.WriteLine($"Movie is Starting, Ssssshhhhhh"); // Print a message indicating that the movie is starting
        }

        public string describe() // Method to describe the movie, returns a string with the movie's details
        {
            return $"The movie {Title} is a {Genre} film with an ESRB rating of {ESRB}"; // Return a string describing the movie
        }
    }
}
