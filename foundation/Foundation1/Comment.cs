using System;


    // Class to represent a Comment
    public class Comment
    {
        public string Author { get; }
        public string Text { get; }

        public Comment(string author, string text)
        {
            Author = author;
            Text = text;
        }
    }
