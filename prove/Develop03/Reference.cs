public class Reference
{
    private string _hmbook;

    private string _hmchapter;

    private string _hmfirstVerse;

    private string _hmlastVerse;

    public Reference(string hmbook, string hmchapter, string hmfirstverse)
    {
        _hmbook = hmbook;
        _hmchapter = hmchapter;
        _hmfirstVerse = hmfirstverse;
        _hmlastVerse = "";
    }
    public Reference(string hmbook, string hmchapter, string hmfirstverse, string hmlastverse)
    {
        _hmbook = hmbook;
        _hmchapter = hmchapter;
        _hmfirstVerse = hmfirstverse;
        _hmlastVerse = hmlastverse;
    }


    public string displayReference()
    {
        if (_hmlastVerse == "")
        {
            return $"{_hmbook} {_hmchapter}:{_hmfirstVerse}";

        }
        else
        {
            return $"{_hmbook} {_hmchapter}:{_hmfirstVerse}-{_hmlastVerse}";

        }
    }
}