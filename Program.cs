using System.Security.Cryptography.X509Certificates;

namespace Interfaces_Joseph_Morgan
{
    internal class Program
    {
        static void Main(string[] args) // Main method is the entry point of the program
        {
           Game game = new Game("FPS", "M", "Call of Battle"); // Create a new game object
            Console.WriteLine(game.describe()); // Describe the game
            game.PlayGame(); // Play the game


            Movie movie = new Movie("Horror", "R", "Night Terrors"); // Create a new movie object
            Console.WriteLine(movie.describe()); // Describe the movie
            movie.PlayMovie(); // Play the movie

        }
    }
}
