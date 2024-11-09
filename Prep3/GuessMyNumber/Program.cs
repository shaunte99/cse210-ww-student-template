using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101); 
        int guess;
        int guessCount = 0;

        Console.WriteLine("Welcome to the Guess My Number Game!");

        bool playAgain = true; 
        while (playAgain)
        {
            do
            {
                Console.Write("What is your guess? ");
                string input = Console.ReadLine();

                
                if (!string.IsNullOrEmpty(input) && int.TryParse(input, out guess))
                {
                    guessCount++;

                    if (guess < magicNumber)
                    {
                        Console.WriteLine("Higher");
                    }
                    else if (guess > magicNumber)
                    {
                        Console.WriteLine("Lower");
                    }
                    else
                    {
                        Console.WriteLine($"You guessed it! It took you {guessCount} guesses.");
                        break; 
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            } while (true);

            
            Console.Write("Do you want to play again? (yes/no): ");
            string playAgainInput = Console.ReadLine();
            playAgain = playAgainInput?.ToLower() == "yes"; 
        }
    }
}
