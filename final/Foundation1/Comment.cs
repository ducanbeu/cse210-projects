class Comment
{
    private String _commentor;
    private String _text;
    public Comment(String commentor, String text)
    {
        _commentor = commentor;
        _text = text;
    }

    public String GetCommentor()
    {
        return _commentor;
    }

    public String GetText()
    {
        return _text;
    }
}