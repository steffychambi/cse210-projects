using System;

public class Reference
{
    private string _book;
    private string _chapter;
    private string _firstNumberVerse;
    private string _finalNumberVerse;

    // A  constructor for a reference of one verse.
    public Reference (string book, string chapter, string firstNumber)
    {
        _book = book;
        _chapter = chapter;
        _firstNumberVerse = firstNumber;

    }
    // A  constructor for a reference of two or more verses.
    public Reference (string book, string chapter, string firstNumber, string finalNumber)
    {
        _book = book;
        _chapter = chapter;
        _firstNumberVerse = firstNumber;
        _finalNumberVerse = "-" + finalNumber;

    }
    public string GetReference()
    {
        string _heading =$"{_book} {_chapter}:{_firstNumberVerse}{_finalNumberVerse}";
        return _heading;
    }
    
}
        
      
    