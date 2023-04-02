class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        List<string> options = new List<string>()
        {
            "1. Create New Goal.",
            "2. List Goals.",
            "3. Save Goals.",
            "4. Load Goals.",
            "5. Record Events.",
            "6. Quit."
        };
        List<string> goalsTypes = new List<string>()
        {
            "1. Simple Goal.",
            "2. Eternal Goal.",
            "3. Checklist Goal."
        };

        Console.WriteLine("Eternal Quest Program");
        Console.WriteLine();

        string number = "0";

        do
        {
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
                }
                else if (selectedType == "2")  
                {
                    EternalGoal goal = new EternalGoal(name, description, points);
                }
                else if (selectedType == "3") 
                {
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int time = Int32.Parse(Console.ReadLine());

                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int bonus = Int32.Parse(Console.ReadLine());

                    ChecklistGoal goal = new ChecklistGoal(name, description, points, time, bonus);
                }
                else 
                {
                    Console.WriteLine("That option does not exist.");
                }

            }
            else if (number == "2") 
            {
            }
            else if (number == "3")  
            {
            }
            else if (number == "4")  
            {
            }
            else if (number == "5")  
            {
            }
            else 
            {
                if (number != "6") 
                {
                    Console.WriteLine("That option does not exist.");
                }
            }
       // Console.Clear();
        }
        while (number != "6"); 
        Console.WriteLine("Goodbye!");
    }
}
