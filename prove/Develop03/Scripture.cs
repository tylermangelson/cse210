class Scripture
{
    private List<Word> _words;
    private Reference _reference;

    public Scripture(string bookName, int chapter, int verse, string text)
    {
        _reference = new Reference(bookName, chapter, verse);
        _words = ConvertToWords(text);
    }

    public Scripture(string bookName, int chapter, int startVerse, int endVerse, string text)
    {
        _reference = new Reference(bookName, chapter, startVerse, endVerse);
        _words = ConvertToWords(text);
    }

    public void ShowScripture()
    {
        _reference.DisplayReference();
        foreach (Word word in _words)
        {
            word.Display();
        }
    }

    public bool HideWords()
    {
        List<Word> visible = new List<Word>();
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visible.Add(word);
            }
        }

        if (visible.Count == 0)
        {
            return false;
        }

        Random random = new Random();
        for (int i = 0; i < 3 && visible.Count > 0; i++)
        {
            int index = random.Next(visible.Count);
            visible[index].Hide();
            visible.RemoveAt(index);
        }
        
        return true;
    }


    // ConvertToWords will convert the paragraph in "text" to list of words. This list is returned
    private List<Word> ConvertToWords(string text)
    {
        List<Word> tempWords = new List<Word>();

        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            Word tempWord = new Word(word);
            tempWords.Add(tempWord);
        }
        return tempWords;
    }

    
}