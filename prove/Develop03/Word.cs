using System;
using System.Collections.Generic;
using System.Text;
public class Word
{
    //the text of the word
    private string _wordText;
    private bool _isVisible;
    private string _newWord;
    
    // A  constructor
    public Word(string wordText, bool isVisible)
    {
        _wordText = wordText;
        //initial visibility of the word
        _isVisible = isVisible;
    }

    public void HideWord()
    {
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
