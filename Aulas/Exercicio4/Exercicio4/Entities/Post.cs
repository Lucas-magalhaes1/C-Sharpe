﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4.Entities
{
    internal class Post
    {
        public DateTime Moment { get; set; }
        public string Title  { get; set; }
        public String Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post() 
        { 
        }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append("Likes - ");
            sb.Append(Moment.ToString("dd/MM /yyyy HH:mm:ss \n"));
            sb.Append(Content);
            sb.AppendLine("\nComments:");
            foreach (Comment comment in Comments)
            {
                sb.AppendLine(comment.Text);
            }
            return sb.ToString();
        }
    }
}
