namespace STUDY.MathGame
{
    internal class Menu
    {
        GameEngine engine = new();

        internal void ShowMenu(string name)
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"Hello {name} !.\nThis is your math game. That's great that you're working on improving yourself.\n");

            bool isGameOn = true;

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
                        engine.AdditionGame("Addition game.");
                        break;
                    case "s":
                        engine.SubtractionGame("Subtraction game.");
                        break;
                    case "m":
                        engine.MultiplicationGame("Multiplication game.");
                        break;
                    case "d":
                        engine.DivisionGame("Division game.");
                        break;
                    case "v":
                        Helpers.GetGames();
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
