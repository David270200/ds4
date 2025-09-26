using System;

class Matriz
{
    private int[,] mat;

    public void Ingresar()
    {
        mat = new int[3, 3]; // inicializamos matriz de 3x3
        for (int f = 0; f < 3; f++)
        {
            for (int c = 0; c < 3; c++)
            {
                Console.Write("Ingrese posicion [" + (f + 1) + "," + (c + 1) + "]: ");
                string linea = Console.ReadLine();
                mat[f, c] = int.Parse(linea);
            }
        }
    }

    public void Imprimir()
    {
        Console.WriteLine("\nLa matriz ingresada es:\n");
        for (int f = 0; f < 3; f++)
        {
            for (int c = 0; c < 3; c++)
            {
                Console.Write(mat[f, c] + " ");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }

    static void Main(string[] args)
    {
        Matriz ma = new Matriz();
        ma.Ingresar();
        ma.Imprimir();
    }
}
