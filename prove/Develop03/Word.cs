public class Word
{

    private string _hmword;
    private bool _hmisHidden;
    public Word(string hmword)
    {
        _hmword = hmword;
        _hmisHidden = false;
    }

    public void hideWord()
    {
        _hmisHidden = true;
    }
    
    public bool isHidden()
    {
        return _hmisHidden;
    }
    public string displayWord()
    {
        if (_hmisHidden == true)
        {
            return "___";
        }
        else
        {
            return _hmword;
        }
    }
}