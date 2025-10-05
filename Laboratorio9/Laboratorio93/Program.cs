using System;

class program
    {
    static void Main(string[] args)
    {
      int dato1, dato2, dato3;
      int ClassTriangulo;
     Console.WriteLine("Ingrese el primer lado del triángulo:");
        dato1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo lado del triángulo:");
        dato2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el tercer lado del triángulo:");
        dato3 = Convert.ToInt32(Console.ReadLine());
        if (dato1 == dato2 && dato2 == dato3)
        {
            ClassTriangulo = 1;
            Console.WriteLine("El triángulo es Equilátero.");
        }
        else if (dato1 == dato2 || dato1 == dato3 || dato2 == dato3)
        {
            ClassTriangulo = 2;
            Console.WriteLine("El triángulo es Isósceles.");
        }
        else
        {
            ClassTriangulo = 3;
            Console.WriteLine("El triángulo es Escaleno.");
        }
    }
}