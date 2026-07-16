using System.Threading;

public class Activity
{
    protected string _hmname;
    protected string _hmdescription;
    protected int _hmduration;

    public Activity(string hmname, string hmdescription)
    {
        _hmname = hmname;
        _hmdescription = hmdescription;
    }
    public void StartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_hmname}. \n{_hmdescription}");
        Console.WriteLine("How long, in seconds, would you like to do this activity?");
        _hmduration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine($"Get ready for the {_hmname}...");
        Count(5);
    }

    public void EndMessage()
    {
        Console.WriteLine($"Thank you for using the {_hmname}!");
        Spinner(3);
        
        
    }
    public void Spinner(int hmseconds)
    {
        DateTime hmstartTime = DateTime.Now;
    DateTime hmendTime = hmstartTime.AddSeconds(hmseconds);

        


    string[] hmanimation =
        {
            "/  ",
            "-  ",
            "\\  ",
            "|  ",
            "/  ",
            "-  ",
            "\\  ",
            "|  ",
            "() ",
            "|  "

        };

        int hmframe = 1;
        while (DateTime.Now < hmendTime)
        {
            Console.Write($"\r{hmanimation[hmframe]}");
            Thread.Sleep(125);
            hmframe++;
            if (hmframe >= hmanimation.Length)
            {
                hmframe = 0;
            }
        }
        Console.Write("\r            \r");

    }

    public void Count(int hmseconds)
    {
        for (int i = hmseconds; i > 0; i--)
        {
            Console.Write(i);
            DateTime hmstartTime = DateTime.Now;
            DateTime hmnextSecond = hmstartTime.AddSeconds(1);

            while (DateTime.Now < hmnextSecond)
            {
                
            }
            Console.Write("\b \b");
        }
    }
}