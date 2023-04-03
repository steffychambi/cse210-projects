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

    public void SetCounter(int counter)
    {
        _counter = counter;
    }

    public override int GetPoints()
    {
        if (_isComplete == false)
        {
            return _points;
        }
        else
        {
            return _points + _bonus;
        }
    }

    public override void RecordEvent()
    {
        if (_counter == _time - 1)
        {
            _isComplete = true;
            _counter += 1;
        }
        else if (_counter < _time)
        {
            _isComplete = false;
            _counter += 1;
        }
    }

    public override string GetStringRepresentation()
    {
        return $"{_type}:{_goalNumber},{_name},{_description},{_points},{_time},{_bonus},{_counter},{_isComplete}";
    }

    public override void ShowGoalMenu2()
    {
        Console.WriteLine($"{_goalNumber}. [{ShowCheckMark()}] {_name} ({_description}) -- Currently completed: {_counter}/{_time}" );
    }

}