using System.Security.Cryptography.X509Certificates;

namespace Interfaces_Joseph_Morgan
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Game game = new Game("FPS", "M", "Call of Battle");
            Console.WriteLine(game.describe());
            game.PlayGame();


            Movie movie = new Movie("Horror", "R", "Night Terrors");
            Console.WriteLine(movie.describe());
            movie.PlayMovie();

        }
    }
}
