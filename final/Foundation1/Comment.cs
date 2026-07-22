class Comment
{
    private string _hmname;
    private string _hmtext;

    public Comment(string name, string text)
    {
        _hmname = name;
        _hmtext = text;
    }

    public string GetName() { 
        
        return _hmname; 
        
    }
    public string GetText() 
    { 
        return _hmtext; 
    }
}