Console.WriteLine("Please type your name");

string name = Console.ReadLine();
DateTime date = DateTime.UtcNow;

Menu(name, date);


#region Menu
void Menu(string name, DateTime date)
{
    Console.WriteLine("-------------------------------------------");

    Console.WriteLine($"Hello {name}. It's {date.DayOfWeek}.\nThis is your math game. That's great that you're working on improving yourself.\n");
    Console.WriteLine($@"What game would you like to play today? Choose from the options below:
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit the program");

    Console.WriteLine("-------------------------------------------");

    string gameSelection = Console.ReadLine();

    switch (gameSelection.Trim().ToLower())
    {
        case "a":
            AdditionGame("Addition game selected.");
            break;
        case "s":
            SubtractionGame("Subtraction game selected.");
            break;
        case "m":
            MultiplicationGame("Multiplication game selected.");
            break;
        case "d":
            DivisionGame("Division game selected.");
            break;
        case "q":
            Console.WriteLine("Goodbye !");
            System.Threading.Thread.Sleep(500);
            break;
        default:
            Console.WriteLine("Input not recognized, the program will now close.");
            System.Threading.Thread.Sleep(1500);
            break;

    }
}

#endregion

#region GameMethods
void AdditionGame(string messageToPrint)
{
    Console.WriteLine(messageToPrint);
}
void SubtractionGame(string messageToPrint)
{
    Console.WriteLine(messageToPrint);
}
void MultiplicationGame(string messageToPrint)
{
    Console.WriteLine(messageToPrint);
}
void DivisionGame(string messageToPrint)
{
    Console.WriteLine(messageToPrint);
}

#endregion