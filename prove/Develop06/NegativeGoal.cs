// This criterion is linked to a Learning Outcome12. Shows creativity and exceeds core requirements
public class NegativeGoal : Goal
{
    public int PenaltyPoints { get; }

    public NegativeGoal(string name, string description, int penaltyPoints) : base(name, description, 0)
    {
        PenaltyPoints = penaltyPoints;
    }

    public override void RecordEvent()
    {
        if (!IsCompleted)
        {
            Points -= PenaltyPoints;
            IsCompleted = true;
        }
    }

    public override string DisplayGoal() => $"[{(IsCompleted ? "X" : " ")}] {Name} ({Description}) - Penalty: {PenaltyPoints} points";

    public override string ToDataString() => $"NegativeGoal|{Name}|{Description}|{PenaltyPoints}|{IsCompleted}";
}
