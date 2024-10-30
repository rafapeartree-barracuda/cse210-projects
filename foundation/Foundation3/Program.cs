using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        var activities = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 3), 30, 4.8),
            new Cycling(new DateTime(2022, 11, 3), 40, 25.0),
            new Swimming(new DateTime(2022, 11, 3), 45, 30)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
