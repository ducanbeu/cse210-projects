class Word
{
    private String _text;
    private String[] _wordsToRemove;

    public Word(String text)
    {
        _text = text;
        
        var words = text.Split(' ')
                         .Distinct()
                         .ToList();

        
        Random random = new Random();
        words = words.OrderBy(x => random.Next()).ToList();

        _wordsToRemove = words.ToArray();
    }

    public int GetUniqueWords()
    {
        return _wordsToRemove.Length;
    }

    public void showText()
    {
        Console.WriteLine(_text);
    }
    
    public void showVerse(int numberOfWords)
    {
        _text = _text.Replace(_wordsToRemove[numberOfWords], "");
        showText();
    }
}