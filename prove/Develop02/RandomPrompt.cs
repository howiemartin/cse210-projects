public class RandomPrompt
{

        public int hmLastUsedNumb = -1;

    
        List<string> hmprompts = new List<string> 
        {
            "What did you do today that made someone else smile?", 
        "What do you wish you could have done better today?", 
        "What is something you did that made yourself proud?", 
        "Who was the first person you talked to today, and what did you say?", 
        "What was the last thing you did that made you smile today?"
        }; 
    

    public string SelectPrompt()
    {
        Random hmrand = new Random(); 
        int hmpromptNumb = -1;
        do {

        hmpromptNumb = hmrand.Next(0,5);

        } while (hmLastUsedNumb == hmpromptNumb);
        hmLastUsedNumb = hmpromptNumb;
        return hmprompts[hmpromptNumb];
    }
        
}