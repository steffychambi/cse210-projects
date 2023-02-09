using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello! welcome to Scripture Memorizer");
        Console.WriteLine("Please press 'enter' to continue or type 'quit' to finish");

        string i = "";

        do
        {

        Scripture scripture = new Scripture("Moroni 10: 4-5",
        "And when you receive these things, I would exhort you to a ask God the Eternal Father, in the name of Christ, if these things are not true ; and if you ask with a sincere heart , with a true intent , having faith in Christ, he will manifest to you the truth of them by the power of the Holy Spirit and by the power of the Holy Spirit you will be able to know the truth of all things.");
        scripture.Display();
        
        i = Console.ReadLine();
        // clear the console
        Console.Clear();

        }
        while (i != "quit"); 
    }
}