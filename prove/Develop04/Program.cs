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
                // BreatheActivity BreathingActivity = new BreatheActivity();
                // BreathingActivity.StartRunning();
                // BreathingActivity.ShowSpinner(5);

                // Console.WriteLine("How long, in seconds, would you like to perform this activity?");
                // int duration = int.Parse(Console.ReadLine());

                // DateTime startTime = DateTime.Now;
                // DateTime endTime = startTime.AddSeconds(duration);

                // while (DateTime.Now >= endTime)
                // {
                //     BreathingActivity.DisplayMessage();
                // }


            }
            else if (number == "2") 
            {
              
            }
            else if (number == "3")  
            {
               
            }
            else 
            {
                if (number != "4") 
                {
                    Console.WriteLine("That option does not exist.");
                }
            }
        }
        while (number != "4"); 
        Console.WriteLine("Goodbye!");
    }
}
