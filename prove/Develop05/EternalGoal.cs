public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base (name, description, points)
    {
        _type = "EternalGoal";
    }
    public override void RecordEvent()
    {
        _isComplete = false;
    }

    public override string ShowCheckMark()
    {
        return " ";
    }

}