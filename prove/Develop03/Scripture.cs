public class Scripture
{
    // needs the reference and the passage
    private Reference _hmreference;

    private Passage _hmpassage;


    public Scripture(Reference hmreference, string hmtext)
    {
        _hmreference = hmreference;
        
        _hmpassage = new Passage();
        _hmpassage.createWordList(hmtext);
    }

    public string displayScripture()
    {
        return $"{_hmreference.displayReference()} {_hmpassage.displayPassage()}\n";
    }

    public void hideRandWord()
    {
        _hmpassage.hideRandomWord();
    }
}