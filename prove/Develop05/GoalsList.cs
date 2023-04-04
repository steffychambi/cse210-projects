using System.IO;
public class GoalsList
{
    private List<Goal> _list = new List<Goal>();
    private int _numGoals;
    private int _gainedPoints;
    private int _level = 1;
    private bool _passLevel = false;
    public int GetNumberOfGoals()
    {
        return _numGoals;
    }

    public int GetLevel()
    {
        return _level;
    }

    public bool IsPass()
    {
        return _passLevel;
    }

    public void SetLevel()
    {
        if (_gainedPoints != 0)
        {
            if(_gainedPoints % (100) == 0)
            {
                _level += 1;
                _passLevel = true;
            }
            else
            {
                _passLevel = false;
            }
        }
    }

    public void SetGainedPoints()
    {
        _gainedPoints += 20;
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
            outputFile.WriteLine($"{GetTotalPoints()}");
            foreach (Goal goal in _list)
            {
                outputFile.WriteLine($"{goal.GetStringRepresentation()}");
            }
        }
    }

    public void LoadGoals(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        _gainedPoints += Int32.Parse(lines[0]);

        //Removing the first line.
        int indexToRemove = 0;
        lines = lines.Where((source, index) =>index != indexToRemove).ToArray();

        foreach (string line in lines)
        {
            string[] parts = line.Split(":");

            string type = parts[0];
            string[] variables = parts[1].Split(",");

            if(type == "SimpleGoal")
            {
                SimpleGoal goal = new SimpleGoal(variables[1],variables[2],Int32.Parse(variables[3]));
                goal.SetGoalNumber(Int32.Parse(variables[0]));
                goal.SetIsComplete(variables[4]);
                AddGoals(goal);
            }
            else if(type == "EternalGoal")
            {
                EternalGoal goal = new EternalGoal(variables[1],variables[2],Int32.Parse(variables[3]));
                goal.SetGoalNumber(Int32.Parse(variables[0]));
                goal.SetIsComplete(variables[4]);
                AddGoals(goal);
            }
            else if(type == "ChecklistGoal")
            {
                ChecklistGoal goal = new ChecklistGoal(variables[1],variables[2],Int32.Parse(variables[3]),Int32.Parse(variables[4]),Int32.Parse(variables[5]));
                goal.SetGoalNumber(Int32.Parse(variables[0]));
                goal.SetCounter(Int32.Parse(variables[6]));
                goal.SetIsComplete(variables[7]);
                AddGoals(goal);
            }
        }
    }
}