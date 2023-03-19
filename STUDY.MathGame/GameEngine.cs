using STUDY.MathGame.Models;

namespace STUDY.MathGame
{
    internal class GameEngine
    {
        internal void AdditionGame(string messageToPrint)
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

            Helpers.AddToGameHistory(score, GameType.Addition);

        }
        internal void SubtractionGame(string messageToPrint)
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

            Helpers.AddToGameHistory(score, GameType.Subtraction);

        }
        internal void MultiplicationGame(string messageToPrint)
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

            Helpers.AddToGameHistory(score, GameType.Multiplication);

        }
        internal void DivisionGame(string messageToPrint)
        {
            Console.Clear();
            Console.WriteLine(messageToPrint);
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                int[] divisonNumbers = Helpers.DivisionNumberGenerator();
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

            Helpers.AddToGameHistory(score, GameType.Division);

        }
    }
}
