using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private static List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are your personal strengths?",
        "Who have you helped this week?",
        "When have you felt the Holly Ghost this month?",
        "What are some positive moments from this month?"
    };

    public ListingActivity()
        : base("Listing",
              "This activity will help you reflect by listing positive things in your life.")
    { }

    public override void PerformActivity()
    {
        Start();
        Random rand = new Random();
        int duration = GetDuration();
        int elapsed = 0;

        Console.WriteLine(prompts[rand.Next(prompts.Count)]);
        ShowSpinner(3);

        List<string> items = new List<string>();
        Console.WriteLine("Start listing items:");
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);

        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            items.Add(item);
            currentTime = DateTime.Now;
            // Console.Write("currentTime:");
            // Console.WriteLine(currentTime);
            // Console.Write("futureTime:");
            // Console.WriteLine(futureTime);
        }

        // while (elapsed < duration)
        // {
        //     Console.Write("> ");
        //     string item = Console.ReadLine();
        //     items.Add(item);
        //     elapsed += 5;
        // }

        Console.WriteLine($"You listed {items.Count} items.");
        End();
    }
}
