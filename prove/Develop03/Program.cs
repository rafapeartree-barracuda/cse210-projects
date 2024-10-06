using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop03 World!");


        // This criterion is linked to a Learning Outcome10. Shows creativity and exceeds core requirements
        Scripture scripture = new Scripture("scripture.txt");

        while (!scripture.AllWordsHidden())
        {
            Console.Clear();
            scripture.DisplayScripture();
            Console.WriteLine("Press enter to hide words or type 'quit' to exit.");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords();
        }

        Console.WriteLine("Thank for using this program.");
    }
}
