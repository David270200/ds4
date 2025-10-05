using System;

class program {
    static void Main(string[] args)
    {
        //declaracion de variables para recorrer los numeros del 1 al 100
        int numero;
        int Div = 0;
        //instruccion para que solo recorra los numeros divisibles entre 3
        for (numero = 1; numero <= 100; numero++)
        {
            Div = numero % 3;
            if (Div == 0)
            {
                Console.WriteLine(numero);
            }
        }
    }
}