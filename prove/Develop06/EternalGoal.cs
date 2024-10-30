public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }

    public override void RecordEvent()
    {
        Points += Points;
    }

    public override string DisplayGoal() => $"[∞] {Name} ({Description})";

    public override string ToDataString() => $"EternalGoal|{Name}|{Description}|{Points}";
}
