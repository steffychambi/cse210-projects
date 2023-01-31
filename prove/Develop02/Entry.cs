using System;
using System.Collections.Generic;
    public class Entry
    {
        public string _prompt;
        public string _input;

        // A special method constructor.
        public Entry()
        {
        }
        public string MakeEntry()
        {
           string _entry = _prompt +" / "+ _input +".";
           return _entry;
        }
        
    }
        
      
    