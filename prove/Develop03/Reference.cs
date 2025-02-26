class Reference
{
    private String _book;
    private String _chapter;
    private int[] _verse;

    public Reference(String book, String chapter, int[] verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    
    public String showReference()
    {
        if (_verse.Length > 1)
        {
            return $"{_book} {_chapter}:{_verse[0]}-{_verse[_verse.Length-1]}";
        }
        return $"{_book} {_chapter}:{_verse}";
    }
}