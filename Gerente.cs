using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public class Gerente : Persona
    {
        public int LikeCount { get; set; }
        public Gerente() : base("", 0, 0.0, "", "", "")
        {
            this.LikeCount = 0;
        }

        public Gerente(int likeCount, string name, int age, double salary, string username, string password, string email)
            : base(name, age, salary, username, password, email)
        {
            this.LikeCount = likeCount;
        }

        public override void Print()
        {
            Console.WriteLine("Like count: {0}", this.LikeCount);
            base.Print();
        }
    }
}
