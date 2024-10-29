//This criterion is linked to a Learning Outcome11. Shows creativity and exceeds core requirements Keeping a log of how many times activities were performed

using System;
using System.IO;

public static class LogManager
{
    private static readonly string logFilePath = "activity_log.txt";

    public static void InitializeLog()
    {
        if (!File.Exists(logFilePath))
        {
            File.WriteAllLines(logFilePath, new[]
            {
                "BreathingActivity: 0",
                "ReflectionActivity: 0",
                "ListingActivity: 0"
            });
        }
    }

    public static void LogActivity(string activityName)
    {
        var lines = File.ReadAllLines(logFilePath);

        for (int i = 0; i < lines.Length; i++)
        {
            if (lines[i].StartsWith(activityName))
            {
                string[] parts = lines[i].Split(':');
                int count = int.Parse(parts[1].Trim()) + 1;
                lines[i] = $"{activityName}: {count}";
            }
        }

        File.WriteAllLines(logFilePath, lines);
    }
    public static void DisplayLog()
    {
        Console.WriteLine("\nActivity Log:");
        var lines = File.ReadAllLines(logFilePath);
        foreach (var line in lines)
        {
            Console.WriteLine(line);
        }
    }
}
