using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlifEntry.TaskSets.TaskSet3.Task2
{
    public class Post
    {
        public string? Text { get; private set; }
        public int Likes { get; private set; }
        public List<Comment> Comments { get; private set; } = new();

        public void SetPost(string text)
        {
            Text = text;
        }

        public void AddLike()
        {
            Likes++;
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public string GetInfo()
        {
            StringBuilder sb = new StringBuilder($"Text: {Text}\nLikes: {Likes}\n");
            Comments.ForEach(x => sb.AppendLine($"{x.Author}: {x.Description}"));
            return sb.ToString();
        }
    }
}
