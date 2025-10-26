using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese N numeros para calcular la secuencia:");
        int N = Convert.ToInt32(Console.ReadLine());

        if (N <= 0)
        {
            Console.WriteLine("ingrese un numero mayor a 0");
            return;
        }

        long a = 0; // primer numero
        long b = 1; // segundo numero
        long suma = 0;

        Console.WriteLine("Sucesión de Fibonacci:");

        for (int i = 1; i <= N; i++)
        {
            Console.Write(a + " "); 
            suma += a;             

            long siguiente = a + b; // calculamos el siguiente número
            a = b;                  // actualizamos a
            b = siguiente;          // actualizamos b
        }
    }
}
