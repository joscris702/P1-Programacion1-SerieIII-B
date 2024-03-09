using System;

namespace CalculadoraDeCompras
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hola bienvenido a este humilde programa un gusto saludarlo");
            Console.WriteLine("Por favor, ingresa el precio de 3 productos:");

            double precio1 = PedirPrecio("Producto 1");
            double precio2 = PedirPrecio("Producto 2");
            double precio3 = PedirPrecio("Producto 3");

            double totalBruto = precio1 + precio2 + precio3;

            double descuento = 0;
            if (totalBruto > 100)
            {
                descuento = totalBruto * 0.15;
            }

            double totalConDescuento = totalBruto - descuento;

            Console.WriteLine($"Total de la compra bruta: ${totalBruto:F2}");
            Console.WriteLine($"Descuento aplicado: ${descuento:F2}");
            Console.WriteLine($"Total con descuento: ${totalConDescuento:F2}");
        }

        static double PedirPrecio(string nombreProducto)
        {
            Console.Write($"Ingresa el precio de {nombreProducto}: ");
            string input = Console.ReadLine();
            double precio;
            while (!double.TryParse(input, out precio) || precio < 0)
            {
                Console.Write("Precio inválido. Ingresa un valor positivo: ");
                input = Console.ReadLine();
            }
            return precio;
        }
    }
}
