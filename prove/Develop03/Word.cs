using System;
class Word
{
    private string _text;
    private bool _isHidden;

    // Constructor
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // Hide the word
    public void Hide()
    {
        _isHidden = true;
    }

   
    public void Show()
    {
        _isHidden = false;
    }

   
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Get the display text for the word (hidden words are replaced with "____")
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}