using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public class Empleado : Persona
    {
        public string WhatsApp { get; set; }
        public Empleado() : base("", 0, 0.0, "", "", "")
        {
            this.WhatsApp = "";
        }

        public Empleado(string whatsapp, string name, int age, double salary, string username, string password, string email)
            : base(name, age, salary, username, password, email)
        {
            this.WhatsApp = whatsapp;
        }

        public override void Print()
        {
            Console.WriteLine("WhatsApp: {0}", this.WhatsApp);
            base.Print();
        }
    }
}
