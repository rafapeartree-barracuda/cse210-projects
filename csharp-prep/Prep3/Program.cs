using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep3 World!");
        Random random = new Random();  // Random number generator
        bool playAgain = true;  // To control whether to replay the game

        while (playAgain)
        {
            int correctNumber = random.Next(1, 101);  
            int guess = 0;
            int guessCount = 0;

            Console.WriteLine("I have chosen a number between 1 and 100. Try to guess it!");

            while (guess != correctNumber)
            {
                Console.Write("Enter your guess: ");
                try
                {
                    guess = int.Parse(Console.ReadLine());  
                    guessCount++;

                    if (guess < correctNumber)
                    {
                        Console.WriteLine("Too low! Try again.");
                    }
                    else if (guess > correctNumber)
                    {
                        Console.WriteLine("Too high! Try again.");
                    }
                    else
                    {
                        Console.WriteLine("Congratulations! You guessed the correct number!");
                    }
                }
                catch
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }

            // Inform the user of how many guesses they made
            Console.WriteLine($"You guessed the correct number in {guessCount} guesses.");

            Console.Write("Do you want to play again? (yes/no): ");
            string response = Console.ReadLine().ToLower();

            if (response != "yes")
            {
                playAgain = false; 
            }
        }

        Console.WriteLine("Thanks for playing! Goodbye.");
    }

}