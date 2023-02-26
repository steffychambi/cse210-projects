using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to mindfulness program");
        Console.WriteLine();

        List<string> options = new List<string>()
                    {
                    "1. Start breathing activity",
                    "2. Start reflecting activity",
                    "3. Start listing activity",
                    "4. Quit",
                    };
    
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


            if (number == "1") 
            {
                
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
