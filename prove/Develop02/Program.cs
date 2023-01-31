using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello! welcome to Journal Program");
        Console.WriteLine("Please choose one of the following options:");

        List<string> _options = new List<string>();
        _options.Add("1. Write a new entry");
        _options.Add("2. Review all the journal");
        _options.Add("3. Save the journal to a file");
        _options.Add("4. Load the journal from a file");
        _options.Add("5. Enter a date to review that day`s entry"); 
        _options.Add("6. Quit");

        foreach (string _option in _options)
        {
            Console.WriteLine(_option); 
        }

        Console.WriteLine("Type the number of the option you chose. ");
        string _number = Console.ReadLine();

        Journal journal = new Journal();

        do
        {

            if (_number == "1") 
            {
                Entry entry = new Entry();
                Prompt prompt = new Prompt();
                entry._prompt = prompt.PromptGenerator();
                Console.WriteLine(entry._prompt);
                entry._input = Console.ReadLine();
                journal.entries.Add(DateTime.Now.ToString("MMMM dd - yyyy - HH:mm:ss"), entry.MakeEntry());
                Console.WriteLine("Entry added successfully.");
            }
            else if (_number == "2") 
            {
                Console.WriteLine("JOURNAL:");
                journal.DisplayAll();
            }
            else if (_number == "3")  
            {
                Console.WriteLine("Enter the name of the file (in which you are going to save your journal) in the next format: 'Name.ext' ");
                Console.WriteLine("e.g. MyFile.txt");
                journal._filename = Console.ReadLine();
                journal.SaveJournal();
            }
            else if (_number == "4")  
            {
                Console.WriteLine("Enter the name of the file (from where you are going to load your journal) in the next format: 'Name.ext' ");
                Console.WriteLine("e.g. MyFile.txt");
                journal._filename = Console.ReadLine();
                journal.LoadJournal();
            }
            else if (_number == "5") 
            {
                Console.WriteLine("Type the date and the time of the entry you want to review in the next format: 'MMMM dd - yyyy - HH:mm:ss'");
                Console.WriteLine("e.g. July 31 - 2023 - 23:01:37");
                journal._date = Console.ReadLine() + " ";
                journal.DisplayOne();
            }
            else 
            {
                Console.WriteLine("That option does not exist.");
            }
        foreach (string _option in _options)
        {
            Console.WriteLine(_option); 
        }
        Console.WriteLine("Choose another option.");
        _number = Console.ReadLine();
        }
        while (_number != "6"); 
    Console.WriteLine("Goodbye!");
    }
        
}
