using System;
using System.Threading;

public abstract class Activity
{
    private string name;
    private string description;
    private int duration;

    public Activity(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public void Start()
    {
        Console.WriteLine($"Starting {name} Activity...");
        Console.WriteLine(description);
        Console.Write("Enter the duration in seconds: ");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);
    }

    public void End()
    {
        Console.WriteLine("\nWell done! You've completed the activity.");
        Console.WriteLine($"\nYou finished the {name} Activity for {duration} seconds.");
        ShowSpinner(3);

        //This criterion is linked to a Learning Outcome11. Shows creativity and exceeds core requirements Keeping a log of how many times activities were performed
        LogManager.LogActivity(GetType().Name); 
        LogManager.DisplayLog();                
    }

    protected int GetDuration() => duration;

    protected void ShowSpinner(int seconds)
    {
        // for (int i = 0; i < seconds; i++)
        // {
        //     Console.Write(".");
        //     Thread.Sleep(1000);
        // }
        // Console.WriteLine();
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        Console.WriteLine();
        // for (int i = seconds; i > 0; i--)
        foreach (string s in animationStrings)
        {
            // Console.WriteLine($"...{i}");
            // Thread.Sleep(1000);
            Console.Write(s);
            Thread.Sleep(200);
            Console.Write("\b \b");
        }

        Console.WriteLine();
    }

    public abstract void PerformActivity();
}
