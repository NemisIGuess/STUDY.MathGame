using STUDY.MathGame.Models;

namespace STUDY.MathGame
{
    internal class Helpers
    {
        internal static List<Game> gamesPlayed = new List<Game>
        {
            new Game { Date = DateTime.Now.AddDays(1), Type = GameType.Addition, Score = 5 },
            new Game { Date = DateTime.Now.AddDays(2), Type = GameType.Multiplication, Score = 4 },
            new Game { Date = DateTime.Now.AddDays(3), Type = GameType.Division, Score = 4 },
            new Game { Date = DateTime.Now.AddDays(4), Type = GameType.Subtraction, Score = 3 },
            new Game { Date = DateTime.Now.AddDays(5), Type = GameType.Addition, Score = 1 },
            new Game { Date = DateTime.Now.AddDays(6), Type = GameType.Multiplication, Score = 2 },
            new Game { Date = DateTime.Now.AddDays(7), Type = GameType.Division, Score = 3 },
            new Game { Date = DateTime.Now.AddDays(8), Type = GameType.Subtraction, Score = 4 },
            new Game { Date = DateTime.Now.AddDays(9), Type = GameType.Addition, Score = 4 },
            new Game { Date = DateTime.Now.AddDays(10), Type = GameType.Multiplication, Score = 1 },
            new Game { Date = DateTime.Now.AddDays(11), Type = GameType.Subtraction, Score = 0 },
            new Game { Date = DateTime.Now.AddDays(12), Type = GameType.Division, Score = 2 },
            new Game { Date = DateTime.Now.AddDays(13), Type = GameType.Subtraction, Score = 5 },
        };

        internal static string GetName()
        {
            Console.WriteLine("Please type your name");

            string name = Console.ReadLine();
            return name;
        }

        internal static void PrintGames()
        {
            var gamesToPrint = gamesPlayed.Where(game => game.Date.Day > DateTime.Now.Day).OrderByDescending(game => game.Date);

            Console.Clear();
            Console.WriteLine("Games history");
            Console.WriteLine("-------------------------------------------");
            foreach (Game game in gamesToPrint)
            {
                Console.WriteLine($"{game.Date} - {game.Type}: {game.Score} points.");
            }
            Console.WriteLine("-------------------------------------------\n");
            Console.WriteLine("Press any key to go back to the menu.");
            Console.ReadLine();
        }

        internal static int[] DivisionNumberGenerator()
        {
            Random randomGenerator = new Random();
            int firstNumber = randomGenerator.Next(1, 99);
            int secondNumber = randomGenerator.Next(1, 99);

            int[] result = new int[2];

            while (firstNumber % secondNumber != 0)
            {
                firstNumber = randomGenerator.Next(1, 99);
                secondNumber = randomGenerator.Next(1, 99);
            }

            result[0] = firstNumber;
            result[1] = secondNumber;

            return result;
        }

        internal static void AddToGameHistory(int gameScore, GameType gameType)
        {
            gamesPlayed.Add(new Game { 
                Date = DateTime.Now,
                Score = gameScore,
                Type = gameType
            });
        }

    }
}
