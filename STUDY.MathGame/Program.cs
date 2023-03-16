using System.Threading.Tasks.Sources;
using static System.Formats.Asn1.AsnWriter;

string name = GetName();

Menu(name);

string GetName()
{
    Console.WriteLine("Please type your name");

    string name = Console.ReadLine();
    return name;
}
void Menu(string name)
{
    Console.WriteLine("-------------------------------------------");

    Console.WriteLine($"Hello {name} !.\nThis is your math game. That's great that you're working on improving yourself.\n");
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

        if (i == 4) Console.WriteLine($"Your score is {score}");
    }

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

        if (i == 4) Console.WriteLine($"Your score is {score}");
    }
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

        if (i == 4) Console.WriteLine($"Your score is {score}");
    }
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

        if (i == 4) Console.WriteLine($"Your score is {score}");
    }

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

#endregion