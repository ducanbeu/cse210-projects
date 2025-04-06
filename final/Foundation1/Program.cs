using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>{
            new Video("Video 1", "Author 1", 101),
            new Video("Video 2", "Author 2", 102),
            new Video("Video 3", "Author 3", 103),
            new Video("Video 4", "Author 4", 104),
        };

        foreach (var video in videos)
        {
            for (int i = 0; i < 4; i++)
            {
                video.AddComment("Commentor #"+i,"Comment #"+i);
            }
        }

        foreach (var video in videos)
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("Title: " + video.GetTitle());
            Console.WriteLine("Author: " + video.GetAuthor());
            Console.WriteLine("Duration: " + video.GetDuration(), "seconds");
            Console.WriteLine("Comments:");

            foreach (var comment in video.GetComments())
            {
                Console.WriteLine("     Name: " + comment.GetCommentor());
                Console.WriteLine("     Comment: " + comment.GetText());
            }
            
            Console.WriteLine("---------------------");
        }
    }
}