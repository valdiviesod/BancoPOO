    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BancoPOO
{
    class Ahorros
    {
        int numcuenta;
        private double saldo = 50000;
        private double saldototal = 0;
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
            this.nombre = "Daniel Valdivieso";
            Console.WriteLine("Titular de la cuenta: " + this.nombre);
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
            saldo += saldoconsignar;
            saldototal = saldo;
            Console.WriteLine("¡Consignación exitosa!");
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
            saldo -= saldoretirar;
            if (saldo < 0)
            {
                Console.WriteLine("ERROR, el dinero a retirar es mayor a su saldo, intentelo de nuevo");
            }
            else
            {
                saldototal = saldo;
                Console.WriteLine("¡Retiro exitoso!");
            }

        }

        public double getSaldo()
        {
            return saldototal;
        }

        public double getSaldoInicial()
        {
            return saldo;
        }


    }
}
