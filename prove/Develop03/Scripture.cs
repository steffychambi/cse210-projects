using System;
using System.Collections.Generic;
public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private string _stringText;
    private List<string> _listText = new List<string>();

    public Scripture(Reference reference, string stringText)
    {
        _reference = reference;
        _stringText = stringText;
    }
    private void ConvertStringToList()
    {
        _listText = _stringText.Split(" ").ToList();
    }

    public void SetWordList()
    {
        ConvertStringToList();
        foreach (string i in _listText)
        {
            Word word = new Word(i);
            _words.Add(word);
        }
    }

    //num = number of words that are going to be hidden
    public void HideWords(int num)
    {
        Random random = new Random();
        for (int i = 1; i <= num; i++)
        {
            //Generating a random index
            int index = random.Next(0,_words.Count);
            _words[index].Hide();
        }
    }

    private string GetNewText()
    {
        string newText = "";
        foreach (Word i in _words)
        {
            newText += i.ReturnNewWord() + " ";
        }
        return newText;
    }

    public void Display()
    {
        Console.WriteLine($"{_reference.GetReference()} {GetNewText()}");
    }

    public int GetTotalWords()
    {
        return _words.Count;
    }
}