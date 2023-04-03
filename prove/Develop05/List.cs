using System.IO;
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
                if(goal.GetIsComplete())
                {
                    Console.WriteLine($"You can`t record this event because is almost complete.");
                }
                else
                {
                    goal.RecordEvent();
                    Console.WriteLine($"Congratulations!! You have earned {goal.GetPoints()} points!");
                    _gainedPoints += goal.GetPoints();
                    Console.WriteLine($"Now you have {GetTotalPoints()} points");
                }
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
            goal.ShowGoalMenu2();
        }
    }

    public void ShowGoalsName()
    {
        foreach (Goal goal in _list)
        {
            goal.ShowGoalName();
        }
    }

    public int GetTotalPoints()
    {
        return _gainedPoints;
    }

    public void SaveList(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Goal goal in _list)
            {
                outputFile.WriteLine($"{goal.GetStringRepresentation()}");
            }
        }
    }
}