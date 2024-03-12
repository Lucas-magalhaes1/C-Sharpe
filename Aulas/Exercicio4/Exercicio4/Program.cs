using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio4.Entities;

namespace Exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("wow that's awesome!");
            Post p1 = new Post(
                DateTime.Parse("21/06/2021"),
                "Traveling to new zealend ",
                "i'm going to visit this wonderful country ",
                12);

            p1.AddComment(c1);
            p1.AddComment(c2);

            Console.WriteLine(p1);
        }
    }
}
