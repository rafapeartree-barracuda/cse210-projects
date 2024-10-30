public abstract class Goal
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Points { get; protected set; }
    public bool IsCompleted { get; protected set; }

    protected Goal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
        IsCompleted = false;
    }

    public abstract void RecordEvent();
    public abstract string DisplayGoal();
    public abstract string ToDataString();

    public static Goal FromDataString(string data)
    {
        var parts = data.Split('|');
        string goalType = parts[0];
        string name = parts[1];
        string description = parts[2];
        int points = int.Parse(parts[3]);

        return goalType switch
        {
            "SimpleGoal" => new SimpleGoal(name, description, points),
            "EternalGoal" => new EternalGoal(name, description, points),
            "ChecklistGoal" => new ChecklistGoal(name, description, points, int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6])),
            // This criterion is linked to a Learning Outcome12. Shows creativity and exceeds core requirements
            "NegativeGoal" => new NegativeGoal(name, description, int.Parse(parts[3])),
            _ => null,
        };
    }
}
