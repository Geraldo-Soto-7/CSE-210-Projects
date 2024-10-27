using System;

 class Program
    {
        static void Main(string[] args)
        {
            // Create a list to hold videos
            List<Video> videos = new List<Video>();

            // Create some video objects
            Video video1 = new Video("How to Learn C#", "George of the Jungle", 300);
            video1.AddComment(new Comment("Patric", "Great tutorial!"));
            video1.AddComment(new Comment("Bob", "Thanks for the help!"));
            video1.AddComment(new Comment("Charlie", "Very informative."));
            
            Video video2 = new Video("Understanding OOP Concepts", "Joe Meridian", 240);
            video2.AddComment(new Comment("David", "This really clarified things for me."));
            video2.AddComment(new Comment("Mike", "Well explained!"));
            
            Video video3 = new Video("C# Advanced Features", "Monic", 360);
            video3.AddComment(new Comment("Goku", "I learned a lot from this video."));
            video3.AddComment(new Comment("Crilin", "Thanks for sharing your knowledge."));
            video3.AddComment(new Comment("Gohan", "Excellent content!"));

            // Add videos to the list
            videos.Add(video1);
            videos.Add(video2);
            videos.Add(video3);

            // Display video information
            foreach (var video in videos)
            {
                Console.WriteLine($"Title: {video.Title}");
                Console.WriteLine($"Author: {video.Author}");
                Console.WriteLine($"Length: {video.Length} seconds");
                Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
                Console.WriteLine("Comments:");
                video.DisplayComments();
                Console.WriteLine(); 
            }
        }
    }
