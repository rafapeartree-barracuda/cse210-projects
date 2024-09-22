using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");


        //Ask the user for a series of numbers, and append each one to a list. Stop when they enter 0.
        List<int> numbers = new List<int>();
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");

            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }



        //1.Compute the sum, or total, of the numbers in the list.
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"SUM: {sum}");



        //2.Compute the average of the numbers in the list.
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"Average: {average}");




        //3.Find the maximum, or largest, number in the list.
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"Max: {max}");



        //Stretch Challenge

        //1.Have the user enter both positive and negative numbers, then find the smallest positive number(the positive number that is closest to zero).
        int smallest = numbers[0];
        foreach (int number in numbers)
        {
            if (number > 0)
            {
                if (number < smallest)
                smallest = number;
            }
        }
        Console.WriteLine($"Smallest: {smallest}");


        //2.Sort the numbers in the list and display the new, sorted list. Hint: There are C# libraries that can help you here, try searching the internet for them.
        numbers.Sort();

        // Step 4: Display the sorted list
        Console.WriteLine("Sorted List:");
        foreach (int number in numbers)
        {
            Console.Write(number + Environment.NewLine);
        }
    }
}