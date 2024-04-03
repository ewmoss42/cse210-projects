using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Title", "Author", "Length");
        video1.comment("Name", "comment");
        video1.comment("Name", "comment");
        video1.comment("Name", "comment");
        video1.comment("Name", "comment");
        videos.Add(video1);
        

        Video video2 = new Video("Title", "Author", "Length");
        video2.comment("Name", "comment");
        video2.comment("Name", "comment");
        video2.comment("Name", "comment");
        video2.comment("Name", "comment");
        videos.Add(video2);
      
        

        Video video3 = new Video("Title", "Author", "Length");
       
        video3.comment("Name", "comment");
        video3.comment("Name", "comment");
        video3.comment("Name", "commento");
        video3.comment("Name", "comment");
        videos.Add(video3);
        

        Video video4 = new Video("Title", "Author", "Length");
        video4.comment("Name", "comment");
        video4.comment("Name", "Wcomment");
        video4.comment("Name", "comment");
        video4.comment("Name", "comment");
        videos.Add(video4);
      

        foreach (Video v in videos)
        {
            v.DisplayVideo();
        }

    }
}