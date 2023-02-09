using System;

    public class Heading
    {
        private string _book;
        private string _chapter;
        private string _firstNumberVerse;
        private string _finalNumberVerse;

        // A  constructor for a scripture of one verse.
        public Heading (string book, string chapter, string firstNumber)
        {
            _book = book;
            _chapter = chapter;
            _firstNumberVerse = firstNumber;

        }
        // A  constructor for a scripture of two or more verses.
        public Heading (string book, string chapter, string firstNumber, string finalNumber)
        {
            _book = book;
            _chapter = chapter;
            _firstNumberVerse = firstNumber;
            _finalNumberVerse = "- " + finalNumber;

        }
        public string GetHeading()
        {
           string _heading =$"{_book} {_chapter}: {_firstNumberVerse}{_finalNumberVerse}";
           return _heading;
        }
        
    }
        
      
    