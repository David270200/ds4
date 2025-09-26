using System;

class PruebaVector1
{
    private int[] sueldos; // declaramos un vector

    public void cargar()
    {
        sueldos = new int[5]; // inicializamos el vector en 5 posiciones
        for (int f = 0; f < sueldos.Length; f++)
        {
            Console.Write("Ingrese sueldo del operario " + (f + 1) + ": ");
            string linea = Console.ReadLine();
            sueldos[f] = int.Parse(linea); // asignamos los sueldos al vector
        }
    }

    // muestra los sueldos de los operarios en el vector sueldos
    public void imprimir()
    {
        Console.WriteLine("\nLos 5 sueldos de los operarios son:\n");
        for (int f = 0; f < sueldos.Length; f++)
        {
            Console.WriteLine("Sueldo del operario " + (f + 1) + ": " + sueldos[f]);
        }
        Console.ReadKey();
    }

    // main principal
    static void Main(string[] args)
    {
        PruebaVector1 pv = new PruebaVector1();
        pv.cargar();   // llamamos al método cargar
        pv.imprimir(); // llamamos al método imprimir
    }
}
