using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        List<string> options = new List<string>()
                    {
                    "1. Start breathing activity",
                    "2. Start reflecting activity",
                    "3. Start listing activity",
                    "4. Quit",
                    };
    
        string number = "0";

        Console.WriteLine("Welcome to Mindfulness Program");
        Console.WriteLine();

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
                BreatheActivity BreathingActivity = new BreatheActivity();
                BreathingActivity.StartRunning();
                BreathingActivity.DisplayMessage();
                BreathingActivity.DisplayOutroMessage();
            }
            else if (number == "2") 
            {
                ReflectionActivity ReflectionActivity = new ReflectionActivity();
                ReflectionActivity.StartRunning();
                ReflectionActivity.RunActivity();
                ReflectionActivity.DisplayOutroMessage();
            }
            else if (number == "3")  
            {
                ListingActivity ListingActivity = new ListingActivity();
                ListingActivity.StartRunning();
                ListingActivity.RunActivity();
                ListingActivity.DisplayOutroMessage();
            }
            else 
            {
                if (number != "4") 
                {
                    Console.WriteLine("That option does not exist.");
                }
            }
        Console.Clear();
        }
        while (number != "4"); 
        Console.WriteLine("Goodbye!");
    }
}
