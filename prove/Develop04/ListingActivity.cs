public class ListingActivity : Activity 
{
    private List<string> _hmlistingPrompts;
        public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
            {
                    _hmlistingPrompts = new List<string>
                    {
                        "Who are people that you appreciate?",
                        "What are personal strengths of yours?",
                        "Who are people that you have helped this week?",
                        "When have you felt the Holy Ghost this month?",
                        "Who are some of your personal heroes?"  
                    };
            }

        public void Run()
            {
                Random hmrand = new Random();
                StartMessage();
                
                Console.WriteLine(_hmlistingPrompts[hmrand.Next(_hmlistingPrompts.Count())]);
                Count(5);
                Console.WriteLine("Begin listing: ");
                DateTime hmstartTime = DateTime.Now;
                DateTime hmendTime = hmstartTime.AddSeconds(_hmduration);
                int hmitemsListed = 0;
                while (hmendTime > DateTime.Now)
                {
                    Console.ReadLine();
                    hmitemsListed++;
                }
                Console.WriteLine($"Well done! You listed {hmitemsListed} thoughts.");
                Console.WriteLine("Returning to menu...");
                Spinner(4);
            }

}