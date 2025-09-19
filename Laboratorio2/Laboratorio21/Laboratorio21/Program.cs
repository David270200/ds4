using System;

namespace Laboratorio21
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //asignacion valor a variable estatica.
            MyClass.Valor = 1;
            Console.WriteLine(MyClass.Valor);
        }
    }
    public class MyClass
    {
        //variable estatica
        public static int Valor { get; set; }
    }
}