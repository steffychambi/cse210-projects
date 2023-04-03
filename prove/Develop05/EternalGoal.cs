public class EternalGoal : Goal
{
    private int _counter;

    public EternalGoal(string name, string description, int points) : base (name, description, points)
    {
        _type = "EternalGoal";
        _counter = 0;
    }

    public override void RecordEvent()
    {
        _isComplete = false;
        _counter += 1;
    }

    public override string ShowCheckMark()
    {
        return " ";
    }

    public override int GetPoints()
    {
        return _points * _counter;
    }

}