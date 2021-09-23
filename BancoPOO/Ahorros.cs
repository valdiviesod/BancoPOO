    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BancoPOO
{
    class Ahorros
    {
        int numcuenta;
        int saldo;
        private double saldoconsignar;
        private double saldoretirar;
        String nombre;

        public void NumeroCuenta()
        {
            Random rnd = new Random();
            numcuenta = rnd.Next(10000000, 99999999);
            Console.WriteLine("Número de cuenta: " + numcuenta);
        }
        public void MostrarNombre()
        {
            Console.WriteLine("Nombre: ");
            this.nombre = Console.ReadLine();
            Console.WriteLine(this.nombre);
        }

        public double GetSaldoConsignar()
        {
            return this.saldoconsignar;
        }

        public void SetSaldoConsignar(double dato)
        {
            this.saldoconsignar = dato;
        }

        public void Consignar()
        {
            this.saldo = 50000;
            double consignar;
            consignar = this.saldo + this.saldoconsignar;
            Console.WriteLine("Su saldo actual es: " + consignar);
        }

        public double GetSaldoRetirar()
        {
            return this.saldoretirar;
        }

        public void SetSaldoRetirar(double dato2)
        {
            this.saldoretirar = dato2;
        }

        public void Retirar()
        {
            this.saldo = 50000;
            double retirar;
            retirar = this.saldo - this.saldoretirar;
            if (retirar > this.saldo)
            {
                Console.WriteLine("ERROR, el dinero a retirar es mayor a su saldo, intentelo de nuevo");
            }
            else
            {
                Console.WriteLine("Su saldo actual es: " + retirar);
            }






        }
    }
}
