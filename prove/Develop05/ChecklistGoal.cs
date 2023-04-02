public class ChecklistGoal : Goal
{
    private int _bonus;
    private int _time;
    private int _counter;
    public ChecklistGoal(string name, string description, int points, int time, int bonus) : base (name, description, points)
    {
        _type = "ChecklistGoal";
        _time = time;
        _bonus = bonus;
        _counter = 0;    
    }
    public override void RecordEvent()
    {
        if(_counter == _time)
        {
            _isComplete = true;
        }
        else
        {
            _counter += 1;
            _isComplete = false;
        }
    }

    public override string GetStringRepresentation()
    {
        return $"{_type}:{_name},{_description},{_points},{_bonus},{_counter},{_time}";
    }

    public override void ShowGoal()
    {
        Console.WriteLine($"[{ShowCheckMark()}] {_name} ({_description}) -- Currently completed: {_counter}/{_time}" );
    }

}