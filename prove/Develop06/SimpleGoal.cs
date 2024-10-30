public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : base(name, description, points) { }

    public override void RecordEvent()
    {
        if (!IsCompleted)
        {
            Points += Points;
            IsCompleted = true;
        }
    }

    public override string DisplayGoal() => $"[{(IsCompleted ? "X" : " ")}] {Name} ({Description})";

    public override string ToDataString() => $"SimpleGoal|{Name}|{Description}|{Points}|{IsCompleted}";
}
