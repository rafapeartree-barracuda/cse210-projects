using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Video video1 = new Video("Learning C# Basics", "John Doe", 600);
        Video video2 = new Video("How to Cook Pasta", "Jane Smith", 900);
        Video video3 = new Video("Exploring the Universe", "Neil Armstrong", 1200);

        video1.AddComment(new Comment("Alice", "Great explanation!"));
        video1.AddComment(new Comment("Bob", "This helped me a lot."));
        video1.AddComment(new Comment("Charlie", "Keep up the good work!"));

        video2.AddComment(new Comment("Dave", "Delicious recipe!"));
        video2.AddComment(new Comment("Eve", "Easy to follow, thanks."));
        video2.AddComment(new Comment("Frank", "I loved the tips!"));

        video3.AddComment(new Comment("Grace", "Mind-blowing content!"));
        video3.AddComment(new Comment("Hank", "Incredible!"));
        video3.AddComment(new Comment("Isaac", "I want to learn more!"));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}
