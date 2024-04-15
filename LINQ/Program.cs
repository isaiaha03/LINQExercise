using System;
using System.Linq;
using System.Collections;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> games = new List<string>
            {
                "League of Legends",
                "Valorant",
                "Call of Duty",
                "Counter Strike 2",
                "Minecraft",
                "Pokemon",
                "Grand Theft Auto V",
            };

            var gamesOrdered = games.OrderBy(game => game.Length);

            Console.WriteLine("Ordered list of games by length of name: ");
            foreach ( var game in gamesOrdered)
            {
                Console.WriteLine(game);
            }
        }
    }
}
