class Word
{
    private string _word;
    private bool _hidden;
    public Word (string word)
    {
        _word = word;
        _hidden = false;
    }

    public void Hide()
    {
        _hidden = true;
    }

    public bool IsHidden()
    {
        return _hidden;
    }

    public void Display()
    {
        Console.Write($"{GetWordString()} ");
    }

     public string GetWordString() //If the word is supposed to be hidden, this replaces it with underscores.
    {
        string returnString = "";
        if (_hidden)
        {
            for(int i = 0; i < _word.Length; i++)
            {
                returnString += '_';
            }
        }
        else
        {
            returnString = _word;
        }
        return returnString;
    }

}