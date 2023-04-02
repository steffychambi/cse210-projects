using System;
using System.Collections.Generic;
using System.Text;
public class Word
{
    //the text of the word
    private string _wordText;
    //visibility of the word
    private bool _isVisible;
    private string _newWord;
    
    public Word(string wordText)
    {
        _wordText = wordText;
        _isVisible = true;
    }

    public bool GetIsVisible()
    {
        return _isVisible;
    }

    public void Hide()
    {
        _isVisible = false;
        int i = 1;
        _newWord = "";
        do
        {
            _newWord += "_";
            i += 1;
        }
        while (i <= _wordText.Length);
    }

    public string ReturnNewWord()
    {
       
        if (_isVisible == true)
        {
            return _wordText;
        }
        else
        {
            return _newWord;
        }
    }

}
