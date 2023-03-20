using STUDY.MathGame.Models;

namespace STUDY.MathGame
{
    internal class Helpers
    {
        internal static List<Game> gamesPlayed = new();

        internal static string GetName()
        {
            Console.WriteLine("Please type your name");

            string name = Console.ReadLine();

            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("The name can't be empty. Please input a name.");
                name = Console.ReadLine();
            }
            return name;
        }

        internal static void PrintGames()
        {
            Console.Clear();
            Console.WriteLine("Games history");
            Console.WriteLine("-------------------------------------------");
            foreach (Game game in gamesPlayed)
            {
                Console.WriteLine($"{game.Date} - {game.Type}: {game.Score}p in {game.GameRounds} rounds. Took {game.GameTime.Hours*60+game.GameTime.Minutes}m{game.GameTime.Seconds}s");
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

        internal static void AddToGameHistory(int gameScore,int gameRounds, GameType gameType, TimeSpan gameTime)
        {
            gamesPlayed.Add(new Game { 
                Date = DateTime.Now,
                Score = gameScore,
                GameRounds = gameRounds,
                Type = gameType,
                GameTime = gameTime
            });
        }

        internal static string ValidateUserInput(string userInput)
        {
            while (string.IsNullOrEmpty(userInput) || !Int32.TryParse(userInput, out _))
            {
                Console.WriteLine("Your answer needs to be an integer. Try again.");
                userInput = Console.ReadLine();
            }

            return userInput;
        }

        internal static int CheckGameRounds()
        {
            Console.WriteLine("Press any key to play 5 rounds or introduce an integer to change the amount of rounds.");
            var userInput = Console.ReadLine();

            if (int.TryParse(userInput, out _))
                return Convert.ToInt32(userInput);

            return 5;
        }
    }
}
