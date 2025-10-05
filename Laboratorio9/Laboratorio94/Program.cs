using System;

class program
{
    //llamado a la Clase Random
    static void Main(string[] args)
        {
        Random random = new Random();
        //metodo para generar un numero entre 2 numeros
        int numeroAleatorio = random.Next(1, 101); // Genera un número entre 1 y 100
        Console.WriteLine($"Número aleatorio generado: {numeroAleatorio}");
        //metodo para generar un arreglo entre 2 numeros aleatorios
        int[] arregloAleatorio = new int[10];
        for (int i = 0; i < arregloAleatorio.Length; i++)
        {
            arregloAleatorio[i] = random.Next(1, 101); // Genera un número entre 1 y 100
        }
        Console.WriteLine("Arreglo aleatorio generado:");
        foreach (int numero in arregloAleatorio)
        {
            Console.WriteLine(numero);
        }
    }

}