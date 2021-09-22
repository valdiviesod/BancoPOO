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
            Console.WriteLine("Ingrese el valor a consignar: ");
            double v = double.Parse(Console.ReadLine());
            ca.SetSaldoConsignar(v);
            ca.Consignar();
            Console.ReadLine();

        }
    }
}
