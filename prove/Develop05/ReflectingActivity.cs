using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    
    private static List<string> prompts = new List<string>
    {
        "> Think of a time when you stood up for someone else.",
        "> Think of a time when you did something really difficult.",
        "> Think of a time when you helped someone in need.",
        "> Think of a time when you did something truly selfless."
    };

    private static List<string> questions = new List<string>
    {
        "> Why was this experience meaningful to you?",
        "> Have you ever done anything like this before?",
        "> How did you feel when it was complete?",
        "> What did you learn from this experience?",
        "> How can you apply this in the future?"
    };

    public ReflectionActivity()
        : base("Reflection",
              "This activity will help you reflect on times in your life when you showed strength and resilience.")
    { }

    public override void PerformActivity()
    {
        Start();
        Random rand = new Random();
        int duration = GetDuration();
        Console.Clear();


        Console.WriteLine("-- Consider the following prompt ---");
        Console.WriteLine(prompts[rand.Next(prompts.Count)]);
        Console.WriteLine();
        Console.Write("\nWhen you have something in your mind, press 'ENTER' or 'return' do Continue");


        while (Console.ReadKey().Key != ConsoleKey.Enter){}
        Console.Clear(); 
        Console.WriteLine();
        Console.Write("\nNow, ponder on each of the following questions as they related to this experience:");
        //  ShowSpinner(3);
        DateTime startTime = DateTime.Now;
        // Console.Write("startTime:");
        // Console.WriteLine(startTime);
        DateTime futureTime = startTime.AddSeconds(duration);
        // Console.Write("futureTime:");
        // Console.WriteLine(futureTime);

        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            Console.WriteLine();
            Console.WriteLine(questions[rand.Next(questions.Count)]);
            ShowSpinner(7000);
            Thread.Sleep(1000);
            currentTime = DateTime.Now;
            // Console.Write("currentTime:");
            // Console.WriteLine(currentTime);
            // Console.Write("futureTime:");
            // Console.WriteLine(futureTime);
        }


        End();
    }
}
