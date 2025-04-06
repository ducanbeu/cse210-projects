class Video
{
    private String _title;
    private String _author;
    private int _seconds;
    private List<Comment> _comments;

    public Video(String title, String author, int seconds)
    {
        _title = title;
        _author = author;
        _seconds = seconds;
        _comments = new List<Comment>{};
    }

    public void AddComment(String commentor, String text)
    {
        Comment comment = new Comment(commentor, text);
        _comments.Add(comment);
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }

    public String GetTitle()
    {
        return _title;
    }

    public String GetAuthor()
    {
        return _author;
    }

    public int GetDuration()
    {
        return _seconds;
    }
}