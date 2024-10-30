using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    private const string FilePath = "goals.txt";

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void ListGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i}. {_goals[i].DisplayGoal()}");
        }
        Console.WriteLine($"Current Score: {_score}");
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            var goal = _goals[goalIndex];
            if (!goal.IsCompleted)
            {
                goal.RecordEvent();
                _score += goal.Points;
                Console.WriteLine($"Event recorded. New score: {_score}");
            }
            else
            {
                Console.WriteLine("This goal is already completed.");
            }
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }

    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter(FilePath))
        {
            writer.WriteLine(_score);
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.ToDataString());
            }
        }
        Console.WriteLine("Goals and score saved.");
    }

    public void LoadGoals()
    {
        if (File.Exists(FilePath))
        {
            _goals.Clear();
            using (StreamReader reader = new StreamReader(FilePath))
            {
                _score = int.Parse(reader.ReadLine());
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Goal goal = Goal.FromDataString(line);
                    if (goal != null) _goals.Add(goal);
                }
            }
            Console.WriteLine("Goals and score loaded.");
        }
        else
        {
            Console.WriteLine("No saved data found.");
        }
    }
}
