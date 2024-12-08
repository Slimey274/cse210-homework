using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Introduction to C#", "Code Wizard", 300);
        Video video2 = new Video("Mastering the Kitchen", "Chef Emily", 600);
        Video video3 = new Video("Adventures in the Wild", "Explorer Jake", 720);

        video1.AddComment(new Comment("Alice", "Great intro to C#!"));
        video1.AddComment(new Comment("Bob", "This was super helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "Looking forward to the next tutorial."));

        video2.AddComment(new Comment("Diana", "Amazing recipes!"));
        video2.AddComment(new Comment("Eve", "So easy to follow."));
        video2.AddComment(new Comment("Frank", "I’ll try this recipe tonight."));

        video3.AddComment(new Comment("Grace", "This was so relaxing."));
        video3.AddComment(new Comment("Hank", "I love nature!"));
        video3.AddComment(new Comment("Ivy", "This inspired me to go hiking."));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (var video in videos)
        {
            Console.WriteLine(video);
            Console.WriteLine("Comments:");
            video.DisplayComments();
            Console.WriteLine(new string('-', 40));
        }
    }
}