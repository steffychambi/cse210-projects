using System;
using System.Collections.Generic;
using System.Text;
public class Word
{
    private string _text;
    private string _chosenWord;
    private string _newWord;
    private int _index;
    private List<int> _listOfIndex;
    private List<string> _words;
    int _totalWords;
    
    // A  constructor
    public Text (string text)
    {
        _text = text;

    }
    
    public void ConvertToList()
    {
        _words = _text.Split(" ").ToList();
    }

    public int GetTotalWords()
    {
        _totalWords = _words.Count;
        return _totalWords;
    }

    private void ChooseIndex()
    {
        Random randomNum = new Random();
        _index = randomNum.Next(0,_totalWords);
        bool isExist = _listOfIndex.find(_index.ToString());
        if (isExist) {
            Console.WriteLine("Element found in the list");
        }
        else {
            Console.WriteLine("Element not found in the given list");
        }
        while (_index != )
    }

    private void ChooseIndex()
    {
        Random randomNum = new Random();
        do
        {
            _index = randomNum.Next(0,_totalWords);
        _   chosenWord = _words[_index];
        }
        while (_index != )
    }
    
    private void GetRenderedWord()
    {
        int number = _chosenWord.Length;
        StringBuilder _underlines = new StringBuilder();
        for (int i = 0; i < number; i++)
        {
            _underlines.Append("_");
        }
        _newWord = _underlines.ToString();
    }

    public string GetNewText()
    {
        ChooseWord();
        GetRenderedWord();
        _words[_index] = _newWord;
        string newText = String.Join(" ", _words);
        return newText;
    }

}
