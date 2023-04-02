public abstract class Goal
{
    protected string _type;
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _isComplete;

    public Goal(string name, string description, int points)
    {

        _name = name;
        _description = description;
        _points = points;
        _isComplete = false;
    }

    public abstract void RecordEvent();

    public virtual string GetStringRepresentation()
    {
        return $"{_type}:{_name},{_description},{_points}";
    }
    
    public virtual void ShowGoal()
    {
        Console.WriteLine($"[{ShowCheckMark()}] {_name} ({_description})");
    }

    public virtual string ShowCheckMark()
    {
        if (_isComplete)
        {
            return "X";
        }
        else
        {
            return " ";
        }
    }

    public int GetPoints()
    {
        return _points;
    }
    
}