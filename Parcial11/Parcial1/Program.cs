using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese un numero impar y >=3: ");
        int N = Convert.ToInt32(Console.ReadLine());

        if (N < 3 || N % 2 == 0)
        {
            Console.WriteLine("N debe ser impar y mayor o igual a 3.");
            return;
        }
        //instruccíon para crear la matriz NxN
        int[,] matriz = new int[N, N];
        int centro = N / 2; //identifico el centro de la matriz

        //instruccion para la Columna central
        for (int i = 0; i < N; i++)
        {
            matriz[i, centro] = i + 1;
        }

        // instruccion para la fila central
        for (int j = 0; j < N; j++)
        {
            matriz[centro, j] = N - j;
        }

       
        Console.WriteLine("\nMatriz generada:\n"); // y con esta instruccion mostraremos la matriz
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}



