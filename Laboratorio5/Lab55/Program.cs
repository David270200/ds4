using System;
using System.Collections.Generic;

class Estudiante
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
}

class Program
{
    static void Main()
    {
        List<Estudiante> estudiantes = new List<Estudiante>
        {
            new Estudiante { Nombre = "Ana", Edad = 20 },
            new Estudiante { Nombre = "Juan", Edad = 22 },
            new Estudiante { Nombre = "Sofia", Edad = 19 }
        };

        foreach (Estudiante estudiante in estudiantes)
        {
            Console.WriteLine($"Nombre: {estudiante.Nombre}, Edad: {estudiante.Edad}");
        }
    }
}
