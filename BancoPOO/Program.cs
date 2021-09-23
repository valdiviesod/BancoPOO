using System;
using System.Linq;

namespace BancoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Ahorros ca = new Ahorros();
            ca.NumeroCuenta();
            ca.MostrarNombre();
            int consigna = 1;
            int retira = 2;
            int seleccion;
            Console.WriteLine("1 para consignar, 2 para retirar.");
            seleccion = int.Parse(Console.ReadLine());

            if (seleccion == 1)
            {
                Console.WriteLine("Ingrese el valor a consignar: ");
                double v = double.Parse(Console.ReadLine());
                ca.SetSaldoConsignar(v);
                ca.Consignar();
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Hola");
            }


        }
    }
}
