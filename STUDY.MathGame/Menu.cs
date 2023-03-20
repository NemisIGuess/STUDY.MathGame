namespace STUDY.MathGame
{
    internal class Menu
    {
        GameEngine engine = new();

        internal void ShowMenu(string name)
        {
            Console.Clear();
            Console.WriteLine($"Hello {name} !.\nThis is your math game. That's great that you're working on improving yourself.\n");
            Console.WriteLine("Press any key to show the menu.");
            Console.ReadLine();
            Console.WriteLine("\n");

            bool isGameOn = true;
            int rounds = default;

            do
            {
                Console.Clear();
                Console.WriteLine($@"What game would you like to play today? Choose from the options below:
                A - Addition
                S - Subtraction
                M - Multiplication
                D - Division
                V - View previous games
                Q - Quit the program");
                Console.WriteLine("-------------------------------------------");

                string gameSelection = Console.ReadLine();

                switch (gameSelection.Trim().ToLower())
                {
                    case "a":
                        rounds = Helpers.CheckGameRounds();
                        engine.AdditionGame("Addition game.", rounds);
                        break;
                    case "s":
                        rounds = Helpers.CheckGameRounds();
                        engine.SubtractionGame("Subtraction game.", rounds);
                        break;
                    case "m":
                        rounds = Helpers.CheckGameRounds();
                        engine.MultiplicationGame("Multiplication game.", rounds);
                        break;
                    case "d":
                        rounds = Helpers.CheckGameRounds();
                        engine.DivisionGame("Division game.", rounds);
                        break;
                    case "v":
                        Helpers.PrintGames();
                        break;
                    case "q":
                        Console.WriteLine("Goodbye !");
                        isGameOn = false;
                        System.Threading.Thread.Sleep(500);
                        break;
                    default:
                        Console.WriteLine("Input not recognized");
                        System.Threading.Thread.Sleep(1500);
                        break;

                }
            } while (isGameOn);


        }
    }
}
