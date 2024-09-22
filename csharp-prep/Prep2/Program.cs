using System;

class Program
{
    static void Main(string[] args)
    {
        // Write a program that determines the letter grade for a course according to the following scale:

        // A >= 90
        // B >= 80
        // C >= 70
        // D >= 60
        // F < 60
        // Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade percentage? ");
        string percentAnswer = Console.ReadLine();
        int percentconst = int.Parse(percentAnswer);

        string grade = "";

        if (percentconst >= 90)
        {
            grade = "A";
        }
        else if (percentconst >= 80)
        {
            grade = "B";
        }
        else if (percentconst >= 70)
        {
            grade = "C";
        }
        else if (percentconst >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }
        
        
        
        string sign = "";
        
        int lastDigit = percentconst % 10;

        if (grade != "F")
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        Console.WriteLine($"Your grade is: {grade+ sign}");

        if (percentconst >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Sorry, You did not pass!");
        }
    }
}