using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BancoPOO
{
    class Corriente
    {
        int numerocuentaC;
        int saldoc;
        String nombrec;

        public void NumeroCuentaC()
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
    }
}
