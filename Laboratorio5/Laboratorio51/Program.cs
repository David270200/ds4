private int[] sueldos; //declaramos un vector

public void cargar()
{
    sueldos = new int[6] //inicializamos el vector en 5 
        for (int f = 1; f < 5; f++)
    {
        Console.WriteLine("Ingrese sueldo del operario, " + f + ": ");
        string linea;
        linea = Console.ReadLine();
        sueldos[f] = int.Parse(linea); //asignamos los 5 sueldos al vector
    }
}
//muestra los sueldos de los operarios en el vector sueldos[f]
public void imprimir()
{
    Console.WriteLine("Los 5 sueldos de los operarios son: \n");
    for (int f = 1; f < 5; f++)
    {
        Console.WriteLine("Sueldo del operario " + f + ": " + sueldos[f]);
    }
    Console.ReadKey();
}
//main principal
static void Main(string[] args)
{
    PruebaVector1 pv = new PruebaVector1();
    lab.cargar(); //llamamos al metodo cargar
    lab.imprimir(); //llamamos al metodo imprimir
}