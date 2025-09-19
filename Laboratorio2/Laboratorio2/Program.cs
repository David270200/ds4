using System;

namespace Laboratorio2
{
    class program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            //ejemplo utilizando las variables de instancia de clase.
            client.FirstName = "David";
            client.LastName = "Perez";
            client.Age = 15;
            client.Id = 1;

            Console.WriteLine(client.GetFullName());
        }
    }
    public class Client
    {
        //declarando variables de instancia en clase.
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ushort Age { get; set; }

        public string GetFullName()
        {
            //utilizando variables de instancia dentro de metodos de la clase.
            return FirstName + "" + LastName;
        }
    }
}