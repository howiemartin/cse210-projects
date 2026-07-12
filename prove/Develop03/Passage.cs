public class Passage
{
    private List<Word> _hmwordlist = new List<Word>();
    public void createWordList(string hmpassage)
    {
        foreach (string hmtext in hmpassage.Split(" "))
        {
            Word hmword = new Word(hmtext);
            _hmwordlist.Add(hmword);

        }
    }
    public string displayPassage()
    {
        string hmfullpassage = "";

        foreach (Word hmtext in _hmwordlist)
        {
            hmfullpassage += hmtext.displayWord() + " ";
        }
        return hmfullpassage;
    }

    public void hideRandomWord()
    {
        Random hmrandom = new Random();
    
    int hmwordsHidden = 0;
    int hmattempts = 0;

    while (hmwordsHidden < 3 && hmattempts < 50)
    {
        int hmrandi = hmrandom.Next(_hmwordlist.Count);
        Word hmrandomword = _hmwordlist[hmrandi];

        if (hmrandomword.isHidden() == false) 
        {
            hmrandomword.hideWord();
            hmwordsHidden++;
        }
        
        hmattempts++;
    }
    }
}