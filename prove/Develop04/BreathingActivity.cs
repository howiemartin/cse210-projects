using System.Xml.Serialization;

public class BreathingActivity : Activity 
{
        public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing")
            {

            }

        public void Run()
            {
                StartMessage();
                DateTime hmstartTime = DateTime.Now;
                DateTime hmendTime = hmstartTime.AddSeconds(_hmduration);
                
                while (hmendTime > DateTime.Now)
        {
            
            
        Console.Write("Breath in...");
        Count(4);
        
        Console.Write("\nAnd breath out...");
        Count(5);
            Console.WriteLine("\n\n");
            
        }
        EndMessage();
        Spinner(2);
        Console.Clear();
            }

}