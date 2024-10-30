public class ChecklistGoal : Goal
{
    public int TargetCount { get; }
    public int Bonus { get; }
    public int CurrentCount { get; private set; }

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus, int currentCount = 0)
        : base(name, description, points)
    {
        TargetCount = targetCount;
        Bonus = bonus;
        CurrentCount = currentCount;
    }

    public override void RecordEvent()
    {
        if (CurrentCount < TargetCount)
        {
            Points += Points;
            CurrentCount++;

            if (CurrentCount >= TargetCount)
            {
                Points += Bonus;
                IsCompleted = true;
            }
        }
    }

    public override string DisplayGoal() => $"[{(IsCompleted ? "X" : " ")}] {Name} ({Description}) Completed {CurrentCount}/{TargetCount}";

    public override string ToDataString() => $"ChecklistGoal|{Name}|{Description}|{Points}|{TargetCount}|{Bonus}|{CurrentCount}";
}
