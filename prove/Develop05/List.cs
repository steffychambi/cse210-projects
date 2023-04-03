public class GoalsList
{
    private List<Goal> _list = new List<Goal>();
    private int _gainedPoints;

    public void AddGoals(Goal goal)
    {
        _list.Add(goal);
    }

    public void ShowGoals()
    {
        foreach (Goal goal in _list)
        {
            goal.ShowGoal();
        }
    }

    public void CalculateTotalPoints()
    {
        foreach (Goal goal in _list)
        {
            _gainedPoints += goal.GetPoints();
        }
    }

    public void ShowTotalPoints()
    {
        Console.WriteLine($"You have {_gainedPoints} points");
    }
}