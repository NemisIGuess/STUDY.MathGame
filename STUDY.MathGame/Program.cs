Console.WriteLine("Please type your name");

string name = Console.ReadLine();
DateTime date = DateTime.UtcNow;

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

if (gameSelection.Trim().ToLower() == "a")
{
    Console.WriteLine("Addition game selected.");
}
else if (gameSelection.Trim().ToLower().Trim().ToLower() == "s")
{
    Console.WriteLine("Subtraction game selected.");
}
else if (gameSelection.Trim().ToLower() == "m")
{
    Console.WriteLine("Multiplication game selected.");
}
else if (gameSelection.Trim().ToLower() == "d" )
{
    Console.WriteLine("Division game selected.");
}
else if (gameSelection.Trim().ToLower() == "q")
{
    Console.WriteLine("Goodbye !");
    System.Threading.Thread.Sleep(500);
    Environment.Exit(1);
}
else
{
    Console.WriteLine("Input not recognized, the program will now close.");
    System.Threading.Thread.Sleep(1500);
    Environment.Exit(1);
}