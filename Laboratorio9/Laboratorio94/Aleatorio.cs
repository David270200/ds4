using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio94
{
    internal class Aleatorio
    {
        public Aleatorio() 
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
}
