namespace STUDY.MathGame
{
    internal class Helpers
    {
        static List<string> gamesPlayed = new();

        internal static string GetName()
        {
            Console.WriteLine("Please type your name");

            string name = Console.ReadLine();
            return name;
        }

        internal static void GetGames()
        {
            Console.Clear();
            Console.WriteLine("Games history");
            Console.WriteLine("-------------------------------------------");
            foreach (string game in gamesPlayed)
            {
                Console.WriteLine(game);
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

        internal static void AddToGameHistory(int gameScore, string gameType)
        {
            gamesPlayed.Add($"{DateTime.Now} - {gameType}: scored {gameScore} points.");
        }

    }
}
