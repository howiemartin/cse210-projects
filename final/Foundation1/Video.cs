class Video
{
    private string _hmtitle;
    private string _hmauthor;
    private int _hmlengthSeconds;
    private List<Comment> _hmcomments;

    public Video(string hmtitle, string hmauthor, int hmlengthSeconds)
    {
        _hmtitle = hmtitle;
        _hmauthor = hmauthor;
        _hmlengthSeconds = hmlengthSeconds;
        _hmcomments = new List<Comment>();
    }

    public void AddComment(Comment hmcomment)
    {
        _hmcomments.Add(hmcomment);
    }

    public int GetCommentCount()
    {
        return _hmcomments.Count;
    }

    public List<Comment> GetComments()
    {
        return _hmcomments;
    }

    public string GetTitle() 
    { 
        return _hmtitle;
    }
    public string GetAuthor() 
    { 
        return _hmauthor; 
    }
    public int GetLength() 
    { 
        return _hmlengthSeconds; 
    }
}