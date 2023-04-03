public class GoalsList
{
    private List<Goal> _list = new List<Goal>();
    private int _numGoals;
    private int _gainedPoints;

    public int GetNumberOfGoals()
    {
        return _numGoals;
    }

    public void RecordEvent(int num)
    {
        foreach (Goal goal in _list)
        {
            if(num == goal.GetGoalNumber())
            {
                goal.RecordEvent();
                Console.WriteLine($"Congratulations!! You have earned {goal.GetPoints()} points!");
                _gainedPoints += goal.GetPoints();
            }
        }
    }

    public void AddGoals(Goal goal)
    {
        _list.Add(goal);
        _numGoals += 1;
    }

    public void ShowGoals()
    {
        foreach (Goal goal in _list)
        {
            goal.ShowGoal();
        }
    }

    public int GetTotalPoints()
    {
        return _gainedPoints;
    }
}