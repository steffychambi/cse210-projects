using System;
using System.Collections.Generic;
    public class Scripture
    {
        // Create a dictionary of entries.
        //private List<string> _text = new List<string>();
        private string _text;
        private string _verseHeading;

         // A special method constructor.
        public Scripture(string verseHeading, string text)
        {
            _text = text;
            _verseHeading = verseHeading;

        }
        
        //Getters and Setters
        // public int GetText()
        // {
        //     return _text;
        // }

        // public void SetText( text)
        // {
        //     _text = text;
        // }
        public void Display()
        {
            Console.WriteLine(_verseHeading + " " + _text);
            // foreach (KeyValuePair<string, string> i in entries)
            // {
            //     Console.WriteLine("{0} -> {1}", i.Key, i.Value);
            // }
        }
    }