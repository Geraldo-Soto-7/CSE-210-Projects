using System;


public class Video
    {
        public string Title { get; }
        public string Author { get; }
        public int Length { get; } // Length in seconds
        private List<Comment> comments;

        public Video(string title, string author, int length)
        {
            Title = title;
            Author = author;
            Length = length;
            comments = new List<Comment>();
        }

        // Method to add a comment to the video
        public void AddComment(Comment comment)
        {
            comments.Add(comment);
        }

        // Method to get the count of comments
        public int GetCommentCount()
        {
            return comments.Count;
        }

        // Method to display comments
        public void DisplayComments()
        {
            foreach (var comment in comments)
            {
                Console.WriteLine($"- {comment.Author}: {comment.Text}");
            }
        }
    }