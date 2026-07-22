using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> hmvideos = new List<Video>();

        
        Video v1 = new Video("Drinking the Among Us potion at 3 AM!!", "Dereick XD", 840);
        v1.AddComment(new Comment("Elly", "Can't believe you did this. #justpoopedmypants"));
        v1.AddComment(new Comment("Howie", "Is this real?? I'm shaking"));
        v1.AddComment(new Comment("AJ", "I'll spead the word..."));
        hmvideos.Add(v1);

        Video v2 = new Video("High School Musical: A deep dive", "Y2K Lover", 10520);
        v2.AddComment(new Comment("Rexxel", "The parallels between this movie and World War 2 are astounding."));
        v2.AddComment(new Comment("Rumina", "This makes me want to play HSM sing it."));
        v2.AddComment(new Comment("Avery", "Wait when did this come out, I need to watch this for real."));
        hmvideos.Add(v2);

       
        Video v3 = new Video("The lyricism of Lizzy McAlpine", "Modern Music Millie", 600);
        v3.AddComment(new Comment("Jared", "Lizzy McAlpine threatens to release new music. I am prepared to hide myslef in a basement for a year."));
        v3.AddComment(new Comment("Ghell", "Is that a mountain range? It has alpine in it so it only makes sense"));
        v3.AddComment(new Comment("Ivan", "Hello I am ivan and looking for dateable women in the area."));
        hmvideos.Add(v3);

        foreach (Video v in hmvideos)
        {
            Console.WriteLine($"Title: {v.GetTitle()}\nAuthor: {v.GetAuthor()}\nLength: {v.GetLength()} seconds\nComments: {v.GetCommentCount()}");
            foreach (Comment hmcomment in v.GetComments())
            {
                Console.WriteLine($"  - {hmcomment.GetName()}: {hmcomment.GetText()}");
            }
            
        }
    }
}