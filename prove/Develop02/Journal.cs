using System;
using System.Collections.Generic;
    public class Journal
    {
        // Create a dictionary of entries.
        public Dictionary<string, string> entries = new Dictionary<string, string>();
        public string _date;
        public string _filename;

         // A special method constructor.
        public Journal()
        {
        }
        public void DisplayAll()
        {

            foreach (KeyValuePair<string, string> i in entries)
            {
                Console.WriteLine("{0} -> {1}", i.Key, i.Value);
            }
        }
        public void SaveJournal()
        {
            

            using (StreamWriter outputFile = new StreamWriter(_filename))
            
            foreach (KeyValuePair<string, string> i in entries)
            {
                outputFile.WriteLine("{0} -> {1}", i.Key, i.Value);
            }
            Console.WriteLine("Journal saved successfully.");
        
        }
        public void LoadJournal()
        {

            entries.Clear();
            
            try
            {
                string[] lines = System.IO.File.ReadAllLines(_filename);

                foreach (string line in lines)
                {
                    string[] parts = line.Split("->");
                    entries.Add(parts[0],parts[1]);
                }
                Console.WriteLine("Journal loaded successfully.");
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read");
                Console.WriteLine(e.Message);
            }
        }
        public void DisplayOne()
        {
            if (entries.TryGetValue(_date, out string promptAndEntry))
            {
                Console.WriteLine(promptAndEntry);
            }
            else
            {
                Console.WriteLine("That entry does not exist, try again");
            }
        }
       
       

    }