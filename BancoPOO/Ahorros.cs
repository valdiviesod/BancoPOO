    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BancoPOO
{
    class Ahorros
    {
        int saldo;
        private double saldoconsignar;
        String nombre;

        public void NumeroCuenta()
        {
            for (int i = 0; i <= 0; i++)
            {
                var guid = Guid.NewGuid();

                var justNumbers = new String(guid.ToString().Where(Char.IsDigit).ToArray());
                var seed = int.Parse(justNumbers.Substring(0, 8));

                var random = new Random(seed);
                var value = random.Next(0, 8);

                Console.WriteLine($"Número de cuenta: {seed}");
            }
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
  
    }
}
