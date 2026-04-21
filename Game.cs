using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Joseph_Morgan
{
    internal class Game : IGenre // Game class implements the IGenre interface
    {
        public string ESRB { get; set; } // Property for ESRB rating
        public string Genre { get; set; } // Property for genre type
        public string Title { get; set; } // Property for title of the game

        public Game(string genre, string esrb, string title) // Constructor to initialize the game object with genre, ESRB rating, and title
        {
            Genre = genre; // Set the genre property
            ESRB = esrb; // Set the ESRB property
            Title = title; // Set the title property
        }

        public void PlayGame() // Method to simulate playing the game
        {
            Console.WriteLine($"Game is Starting"); // Print a message indicating that the game is starting
        }
        
        public string describe() // Method to describe the game, returns a string with the game's details
        {
            return $"The game {Title} is a {Genre} game with an ESRB rating of {ESRB}"; // Return a string describing the game
        }
    }
}
