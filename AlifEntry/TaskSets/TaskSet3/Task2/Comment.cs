using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlifEntry.TaskSets.TaskSet3.Task2
{
    public class Comment
    {
        public string? Author { get; private set; }
        public string? Description { get; private set; }


        public Comment(string author, string description)
        {
            Author = author;
            Description = description;
        }
    }
}
