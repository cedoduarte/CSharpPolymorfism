using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona[] personas = new Persona[5];

            personas[0] = new Persona("Carlos", 27, 32000.0, "cedoduarte", "mypass", "carlosduarte.1@hotmail.com");
            personas[1] = new Empleado("+526623382297", "Juan", 30, 50000.0, "juand", "juanpass", "juan@hotmail.com");
            personas[2] = new Gerente(50, "Roberto", 40, 33000.0, "robert", "robertpass", "roberto@hotmail.com");
            personas[3] = new Persona("Ana", 24, 30000.0, "anaduarte", "herpass", "ana@gmail.com");
            personas[4] = new Gerente(100, "Maribel", 55, 60000.0, "maribeluser", "maripassword", "mari@gmail.com");

            foreach (Persona p in personas)
            {
                p.Print();
            }

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
