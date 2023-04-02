public abstract class Goal
{
    protected string _type;
    private string _name;
    private string _description;
    private int _points;
    private bool _isComplete;

    public Goal(string name, string description, int points)
    {

        _name = name;
        _description = description;
        _points = points;
        _isComplete = false;
    }
    public abstract void RecordEvent();
    public abstract string GetStringRepresentation();
    public abstract void ShowGoal();
    
}