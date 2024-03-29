class Program
{   
    //The program exceeds the core requirements because each time the user gain 100 points, pass to another level and receive 20 points more.
    static void Main(string[] args)
    {
        Console.Clear();


        //List for options in the menu.
        List<string> options = new List<string>()
        {
            "1. Create New Goal.",
            "2. List Goals.",
            "3. Save Goals.",
            "4. Load Goals.",
            "5. Record Events.",
            "6. Quit."
        };

        //List to show the types of goals
        List<string> goalsTypes = new List<string>()
        {
            "1. Simple Goal.",
            "2. Eternal Goal.",
            "3. Checklist Goal."
        };

        Console.WriteLine("Eternal Quest Program");
        Console.WriteLine();

        //Initializing the List of Goals
        GoalsList goals = new GoalsList();

        string number = "0";

        do
        {
            goals.SetLevel();
            if (goals.IsPass())
            {
                Console.WriteLine($"Congratulations! You have passed to level number {goals.GetLevel()}");
                goals.SetGainedPoints();
                Console.WriteLine($"You earned 20 points more!!");
                Console.WriteLine($"Press enter to return to the menu.");
                Console.ReadLine();
            }
            else
            {
                //Showing the total points gained to the user
                Console.WriteLine($"You have {goals.GetTotalPoints()} points");
                Console.WriteLine();

                Console.WriteLine("Choose an option:");
                Console.WriteLine();

                foreach (string option in options)
                {
                    Console.WriteLine(option); 
                }
                number = Console.ReadLine();    
                
                Console.Clear();
                
                

                if (number == "1") 
                {
                    foreach (string type in goalsTypes)
                    {
                        Console.WriteLine(type); 
                    }
                    Console.Write("Which type of goal would you like to create? ");
                    string selectedType = Console.ReadLine();

                    Console.Write("What is the name of your goal? ");
                    string name = Console.ReadLine();

                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();

                    Console.Write("What is the amount of points related with it? ");
                    int points = Int32.Parse(Console.ReadLine());

                    if (selectedType == "1")  
                    {
                        SimpleGoal goal = new SimpleGoal(name, description, points);
                        
                        //Adding that goal to the goal list
                        goals.AddGoals(goal);
                        //Assigning a number
                        goal.SetGoalNumber(goals.GetNumberOfGoals());
                    }
                    else if (selectedType == "2")  
                    {
                        EternalGoal goal = new EternalGoal(name, description, points);
                        
                        //Adding that goal to the goal list
                        goals.AddGoals(goal);
                        //Assigning a number
                        goal.SetGoalNumber(goals.GetNumberOfGoals());
                    }
                    else if (selectedType == "3") 
                    {
                        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                        int time = Int32.Parse(Console.ReadLine());

                        Console.Write("What is the bonus for accomplishing it that many times? ");
                        int bonus = Int32.Parse(Console.ReadLine());

                        ChecklistGoal goal = new ChecklistGoal(name, description, points, time, bonus);
                        
                        //Adding that goal to the goal list
                        goals.AddGoals(goal);
                        //Assigning a number
                        goal.SetGoalNumber(goals.GetNumberOfGoals());
                    }
                    else 
                    {
                        Console.WriteLine("That option does not exist.");
                    }
                    Console.WriteLine($"Press enter to return to the menu.");
                    Console.ReadLine();
                }
                else if (number == "2") 
                {
                    Console.WriteLine("The goals are: ");
                    goals.ShowGoals();
                    Console.Write("Press enter to return to the menu.");
                    Console.ReadLine();
                }
                else if (number == "3")  
                {
                    Console.Write("What is the name of the goal file? ");
                    string fileName = Console.ReadLine();
                    goals.SaveList(fileName);
                    Console.WriteLine("Goals saved successfully.");
                    Console.WriteLine("Press enter to return to the menu.");
                    Console.ReadLine();
                }
                else if (number == "4")  
                {
                    Console.Write("What is the name of the goal file? ");
                    string fileName = Console.ReadLine();
                    goals.LoadGoals(fileName);
                    Console.WriteLine("Goals loaded successfully.");
                    Console.Write("Press enter to return to the menu.");
                    Console.ReadLine();
                }
                else if (number == "5")  
                {
                    goals.ShowGoalsName();
                    Console.WriteLine("Which goal did you accomplish?");
                    int num = Int32.Parse(Console.ReadLine());
                    goals.RecordEvent(num);
                    Console.WriteLine($"Press enter to return to the menu.");
                    Console.ReadLine();
                }
                else 
                {
                    if (number != "6") 
                    {
                        Console.WriteLine("That option does not exist.");
                    }
                }
            }
            Console.Clear();
        }
        while (number != "6"); 
        Console.WriteLine("Goodbye!");
    }
}
