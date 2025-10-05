using System;

class program {
    static void Main(string[] args)
    {
        //llamado a la Clase Random
        Random random = new Random();
        //metodo para generar un numero entre 2 numeros
        int numeroAleatorio = random.Next(1, 101); // Genera un número entre 1 y 100
        Console.WriteLine($"Número aleatorio generado: {numeroAleatorio}");
        //metodo para generar un arreglo de numeros no repetidos entre 2 numeros aleatorios
        int[] arregloAleatorio = new int[10];
        for (int i = 0; i < arregloAleatorio.Length; i++)
        {
            int nuevoNumero;
            do
            {
                nuevoNumero = random.Next(1, 101); // Genera un número entre 1 y 100
            } while (arregloAleatorio.Contains(nuevoNumero));
            arregloAleatorio[i] = nuevoNumero;
        }
    }
}