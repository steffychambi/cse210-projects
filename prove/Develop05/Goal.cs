public abstract class Goal
{
    private int _goalNumber;
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

    public void SetGoalNumber(int number)
    {
        _goalNumber = number;
    }

    public int GetGoalNumber()
    {
        return _goalNumber;
    }

    public virtual string GetStringRepresentation()
    {
        return $"{_type}:{_name},{_description},{_points}";
    }
    
    public virtual void ShowGoal()
    {
        Console.WriteLine($"{_goalNumber}. [{ShowCheckMark()}] {_name} ({_description})");
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

    public abstract int GetPoints();

    public abstract void RecordEvent();
    
}