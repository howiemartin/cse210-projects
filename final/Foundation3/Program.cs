using System;

class Program
{
    static void Main(string[] args)
    {
    Address a1 = new Address("943 Chappel Ave", "Omaha", "NE", "USA");
        Wedding hmwedding = new Wedding("Smith Wedding", "Come to the wedding of John and Jane Smith", "5/22/2027", "2:00 PM", a1, "Howie Martin", "Elly Evans", 200);

        Address a2 = new Address("4211", "El Dorado Hills", "CA", "USA");
        BirthdayParty hmbday = new BirthdayParty("Timmy's Birthday", "Celebrate Timmy's 12th birthday!", "1/29/2043", "7:30 PM", a2, "Timmy Martin", "Chocolate", 20);

        Address a3 = new Address("1 Park Way", "Boise", "ID", "USA");
        BBQ hmbbq = new BBQ("Park BBQ", "Community picnic.", "07/23/2026", "12:00 PM", a3, 50, 28, 67);

        List<Event> hmevents = new List<Event>();
    hmevents.Add(hmwedding);
    hmevents.Add(hmbday);
    hmevents.Add(hmbbq);

    foreach(Event hmevent in hmevents)
        {
            Console.WriteLine("\n\nDetais:----------------------");
            Console.WriteLine(hmevent.GetStandardDetails());
            Console.WriteLine("\n\nShort Description:-----------");
            Console.WriteLine(hmevent.GetShortDescription());
        }
}
}