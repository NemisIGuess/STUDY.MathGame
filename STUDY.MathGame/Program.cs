string name = GetName();

List<string> gamesPlayed = new List<string>();

Menu(name);

void Menu(string name)
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
                AdditionGame("Addition game.");
                break;
            case "s":
                SubtractionGame("Subtraction game.");
                break;
            case "m":
                MultiplicationGame("Multiplication game.");
                break;
            case "d":
                DivisionGame("Division game.");
                break;
            case "v":
                GetGames();
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

#region GameMethods
void AdditionGame(string messageToPrint)
{
    Console.Clear();
    Console.WriteLine(messageToPrint);

    int score = 0;

    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
    {
        Random randomGenerator = new Random();
        firstNumber = randomGenerator.Next(1, 9);
        secondNumber = randomGenerator.Next(1, 9);

        Console.WriteLine($"{firstNumber} + {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber + secondNumber)
        {
            Console.WriteLine("Your answer was correct! Type any key for the next question.");
            Console.ReadLine();
            score++;
        }
        else
        {
            Console.WriteLine("Your answer was incorrect! Type any key for the next question.");
            Console.ReadLine();
        }

        if (i == 4)
        {
            Console.WriteLine($"Your score is {score}. Press any key to go back to the menu.");
            Console.ReadLine();
        }
    }

    AddToGameHistory(score, "Addition");

}

void SubtractionGame(string messageToPrint)
{
    Console.Clear();
    Console.WriteLine(messageToPrint);

    int score = 0;

    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
    {
        Random randomGenerator = new Random();
        firstNumber = randomGenerator.Next(1, 9);
        secondNumber = randomGenerator.Next(1, 9);

        Console.WriteLine($"{firstNumber} - {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber - secondNumber)
        {
            Console.WriteLine("Your answer was correct! Type any key for the next question.");
            Console.ReadLine();
            score++;
        }
        else
        {
            Console.WriteLine("Your answer was incorrect! Type any key for the next question.");
            Console.ReadLine();
        }

        if (i == 4)
        {
            Console.WriteLine($"Your score is {score}. Press any key to go back to the menu.");
            Console.ReadLine();
        }
    }

    AddToGameHistory(score, "Subtraction");

}
void MultiplicationGame(string messageToPrint)
{
    Console.Clear();
    Console.WriteLine(messageToPrint);

    int score = 0;

    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
    {
        Random randomGenerator = new Random();
        firstNumber = randomGenerator.Next(1, 9);
        secondNumber = randomGenerator.Next(1, 9);

        Console.WriteLine($"{firstNumber} x {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber * secondNumber)
        {
            Console.WriteLine("Your answer was correct! Type any key for the next question.");
            Console.ReadLine();
            score++;
        }
        else
        {
            Console.WriteLine("Your answer was incorrect! Type any key for the next question.");
            Console.ReadLine();
        }

        if (i == 4)
        {
            Console.WriteLine($"Your score is {score}. Press any key to go back to the menu.");
            Console.ReadLine();
        }
    }

    AddToGameHistory(score, "Multiplication");

}
void DivisionGame(string messageToPrint)
{
    Console.Clear();
    Console.WriteLine(messageToPrint);
    int score = 0;

    for (int i = 0; i < 5; i++)
    {
        int[] divisonNumbers = DivisionNumberGenerator();
        int firstNumber = divisonNumbers[0];
        int secondNumber = divisonNumbers[1];

        Console.WriteLine($"{firstNumber} / {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber / secondNumber)
        {
            Console.WriteLine("Your answer was correct! Type any key for the next question.");
            Console.ReadLine();
            score++;
        }
        else
        {
            Console.WriteLine("Your answer was incorrect! Type any key for the next question.");
            Console.ReadLine();
        }

        if (i == 4)
        {
            Console.WriteLine($"Your score is {score}. Press any key to go back to the menu.");
            Console.ReadLine();
        }
    }

    AddToGameHistory(score, "Division");

}

#endregion

#region Helper methods

string GetName()
{
    Console.WriteLine("Please type your name");

    string name = Console.ReadLine();
    return name;
}

void GetGames()
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

int[] DivisionNumberGenerator()
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

void AddToGameHistory(int gameScore, string gameType)
{
    gamesPlayed.Add($"{DateTime.Now} - {gameType}: scored {gameScore} points.");
}

#endregion