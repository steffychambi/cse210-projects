public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : base (name, description, points)
    {
        _type = "SimpleGoal";
    }
    public override void RecordEvent()
    {
        _isComplete = true;
    }


}