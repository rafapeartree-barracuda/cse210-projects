using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep5 World!");
        
        //DisplayWelcome - Displays the message, "Welcome to the Program!"
        static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to the program!");
        }
  
  
        //PromptUserName - Asks for and returns the user's name (as a string)
        static string PromptUserName()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            return name;
        }


        // PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
        static int PromptUserNumber()
        {
            Console.Write("Enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());

            return number;
        }


        // SquareNumber - Accepts an integer as a parameter and returns that number squared(as an integer)
        static int SquareNumber(int number)
        {
            int numSquare = number * number;
            return numSquare;
        }


        // DisplayResult - Accepts the user's name and the squared number and displays them.
        static void DisplayResult(string name, int numSquare)
        {
            Console.WriteLine($"{name}, the square of your favorite number is {numSquare}");
        }

        {

            DisplayWelcomeMessage();

            string userName = PromptUserName();
            int userNumber = PromptUserNumber();

            int squaredNumber = SquareNumber(userNumber);

            DisplayResult(userName, squaredNumber);
        }
    }
}