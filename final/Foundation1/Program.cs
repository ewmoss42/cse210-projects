using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Funny Moments", "Theodore", "203");
        video1.comment("Noah", "A great video");
        video1.comment("Sophia", "Enjoy your content");
        video1.comment("Henry", "First!");
        video1.comment("Ava", "Second?");
        videos.Add(video1);
        

        Video video2 = new Video("A study of Egypt", "Benjamin", "803");
        video2.comment("Luna", "Very informative");
        video2.comment("Lucas", "Need to work on Pronouncing names");
        video2.comment("Oliver", "Not gonna lie, I expected more");
        video2.comment("Liam", "Told me things I didn't know");
        videos.Add(video2);
      
        

        Video video3 = new Video("Zero to Hero", "Elijah", "214");
       
        video3.comment("Emma", "Very Inpsiring");
        video3.comment("William", "I totally relate to this ");
        video3.comment("Jack", "Love this trope ");
        video3.comment("Hazel", "Name of song?");
        videos.Add(video3);
        

        Video video4 = new Video("9 signs You're a Expert", "Charlotte", "514");
        video4.comment("Willow", "Guess there are 9 signs I am not an expert");
        video4.comment("Kai", "First");
        video4.comment("Samual", "love the satire");
        video4.comment("Abigail", "love your content");
        videos.Add(video4);
      

        foreach (Video v in videos)
        {
            v.DisplayVideo();
        }

    }
}