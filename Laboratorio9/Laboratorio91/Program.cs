using System;

class program
{
    static void Main(string[] args)
    {
        decimal precio;
        string formaPago;
        string tarjeta;
        Console.WriteLine("Ingrese el Precio del producto:");
        precio = Convert.ToDecimal(Console.ReadLine());
        //forma de pago
                Console.WriteLine("Ingrese la forma de pago (Efectivo o Tarjeta):");
        formaPago = Console.ReadLine().ToLower();
        if (formaPago == "efectivo")
        {
            decimal descuento = precio * 0.10m;
            decimal precioFinal = precio - descuento;
            Console.WriteLine($"El precio final con descuento es: {precioFinal:C}");
        }
        //pago con tarjeta
        else if (formaPago == "tarjeta")
        {
            //ingresar el numero de tarjeta, 16 digitos
            Console.WriteLine("Ingrese el número de tarjeta (16 dígitos):");
            tarjeta = Console.ReadLine();
            if (tarjeta.Length == 16 && long.TryParse(tarjeta, out _))
            {
                decimal recargo = precio * 0.05m;
                decimal precioFinal = precio + recargo;
                Console.WriteLine($"El precio final con recargo es: {precioFinal:C}");
            }
            else
            {
                Console.WriteLine("Número de tarjeta inválido. Debe tener 16 dígitos.");
            }
        }
    }
}