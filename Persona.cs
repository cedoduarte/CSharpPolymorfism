using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public class Persona
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public Persona()
        {
            this.Name = "";
            this.Age = 0;
            this.Salary = 0.0;
            this.Username = "";
            this.Password = "";
            this.Email = "";
        }

        public Persona(string name, int age, double salary, string username, string password, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Salary = salary;
            this.Username = username;
            this.Password = password;
            this.Email = email;
        }

        public virtual void Print()
        {
            Console.WriteLine("Name: {0}", this.Name);
            Console.WriteLine("Age: {0}", this.Age);
            Console.WriteLine("Salary: {0}", this.Salary);
            Console.WriteLine("Username: {0}", this.Username);
            Console.WriteLine("Password: {0}", this.Password);
            Console.WriteLine("Email: {0}", this.Email);
            Console.WriteLine("\n");
        }
    }
}
