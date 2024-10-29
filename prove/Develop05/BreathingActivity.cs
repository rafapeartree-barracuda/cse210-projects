using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing",
              "This activity will help you relax by guiding your breathing. Clear your mind and focus on your breath.")
    { }

    public override void PerformActivity()
    {
        Start();
        int duration = GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);

        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            Console.Clear();
            // currentTime = DateTime.Now;
            Console.WriteLine();
            Console.Write("Breathe IN... ");
            // currentTime = DateTime.Now;
            // Console.WriteLine();
            ShowCountdown(6);
            Console.WriteLine();
            Console.Write("Breathe OUT... ");
            ShowCountdown(6);
            currentTime = DateTime.Now;

            Console.WriteLine();
            
            Console.Write("currentTime:");
            Console.WriteLine(currentTime);
            Console.Write("futureTime:");
            Console.WriteLine(futureTime);
        }


        End();
    }

    private void ShowCountdown(int seconds)
    {   
        for (int i = seconds; i > 0; i--)
        // foreach (string s in seconds)
        {
            Console.Write($"{i}");
            // // Thread.Sleep(1000);
            // Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
