using System;
using System.Collections.Generic;

class Comment
{
    public string commenterName;
    public string text;

    public Comment(string name, string commentText)
    {
        commenterName = name;
        text = commentText;
    }
}

class Video
{
    public string title;
    public string author;
    public int length; // in seconds
    private List<Comment> comments = new List<Comment>();

    public Video(string videoTitle, string videoAuthor, int videoLength)
    {
        title = videoTitle;
        author = videoAuthor;
        length = videoLength;
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return comments.Count;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Length: {length} seconds");
        Console.WriteLine($"Number of comments: {GetCommentCount()}");
        Console.WriteLine("Comments:");
        foreach (var comment in comments)
        {
            Console.WriteLine($"  - {comment.commenterName}: {comment.text}");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        // Creating video objects
        Video video1 = new Video("C# OOP Basics", "Tech Guru", 600);
        Video video2 = new Video("AI and Machine Learning", "AI Explained", 900);
        Video video3 = new Video("Web Development in 2025", "Dev Trends", 750);

        // Adding comments to videos
        video1.AddComment(new Comment("Alice", "Great explanation!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "Could you cover more on abstraction?"));

        video2.AddComment(new Comment("David", "Awesome insights on AI!"));
        video2.AddComment(new Comment("Eve", "Nice breakdown of the concepts."));
        video2.AddComment(new Comment("Frank", "Waiting for part 2!"));

        video3.AddComment(new Comment("Grace", "Excited for the future of web dev!"));
        video3.AddComment(new Comment("Hank", "Interesting points about frameworks."));
        video3.AddComment(new Comment("Ivy", "Loved the analysis!"));

        // Storing videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Displaying video details and comments
        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }
}
