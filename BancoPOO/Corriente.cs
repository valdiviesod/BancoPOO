using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BancoPOO
{
    class Corriente
    {
        int numcuentac;
        private double saldoc = 100000;
        private double saldototal = 0;
        private double saldoconsignarc;
        private double saldoretirarc;
        String nombrec;

        public void NumeroCuentaC()
        {
            Random rnd = new Random();
            numcuentac = rnd.Next(10000000, 99999999);
            Console.WriteLine("Número de cuenta: " + numcuentac);
        }
        public void MostrarNombreC()
        {
            this.nombrec = "Daniel Diaz";
            Console.WriteLine("Titular de la cuenta: " + this.nombrec);
        }

        public double GetSaldoConsignarC()
        {
            return this.saldoconsignarc;
        }

        public void SetSaldoConsignarC(double dato)
        {
            this.saldoconsignarc = dato;
        }

        public void ConsignarC()
        {
            saldoc += saldoconsignarc;
            saldototal += saldoc;
            Console.WriteLine("¡Consignación exitosa!");
        }

        public double GetSaldoRetirarC()
        {
            return this.saldoretirarc;
        }

        public void SetSaldoRetirarC(double dato2)
        {
            this.saldoretirarc = dato2;
        }

        public void RetirarC()
        {
            saldoc -= saldoretirarc;
            if (saldoc < 0)
            {
                Console.WriteLine("ERROR, el dinero a retirar es mayor a su saldo, intentelo de nuevo");
            }
            else
            {
                saldototal += saldoc;
                Console.WriteLine("¡Retiro exitoso!");
            }
            
        }

        public double getSaldo()
        {
            return saldototal;
        }

        public double getSaldoInicial()
        {
            return saldoc;
        }

    }
}
