using System;

class Program
{
    static void Main(string[] args)
    {
        // Job job1 = new Job();
        // job1._jobTitle = "Software Engineer";
        // job1._company = "Microsoft";
        // job1._startYear = 2019;
        // job1._endYear = 2022;

        // Job job2 = new Job();
        // job2._jobTitle = "Manager";
        // job2._company = "Apple";
        // job2._startYear = 2022;
        // job2._endYear = 2023;

        // Resume myResume = new Resume();
        // myResume._name = "Allison Rose";

        // myResume._jobs.Add(job1);
        // myResume._jobs.Add(job2);

        // myResume.Display();

        Journal journal = new Journal();
        PromptGeneration promptGenerator = new PromptGeneration();  

        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. New Entry");
            Console.WriteLine("2. Show Entries");
            Console.WriteLine("3. Save Journal");
            Console.WriteLine("4. Load Journal from a File");
            Console.WriteLine("5. Exit");
            Console.WriteLine("");
            Console.WriteLine("Type Code from menu:");
            Console.WriteLine("");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    string response = Console.ReadLine();
                    journal.AddEntry(new Entry(prompt, response));
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    Console.WriteLine("Please, type the file name:");
                    string filename = Console.ReadLine();
                    journal.SaveToFile(filename);
                    break;
                case "4":
                    Console.WriteLine("Please, type the file name:");
                    filename = Console.ReadLine();
                    journal.LoadFromFile(filename);
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid Option, try again");
                    break;
            }
        }
    }
}