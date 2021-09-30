using System;
using System.Linq;

namespace BancoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            String ahorros = "a";
            String corriente = "c";
            String selecciona;
            Console.WriteLine("Escriba a para seleccionar una cuenta de ahorros o c para una cuenta corriente.");
            selecciona = Console.ReadLine();

                if (selecciona == ahorros)
                {
                    int verinfo = 0;
                    int continuar = 9;
                    int seleccionado;
                    Console.WriteLine("Seleccione 0 para ver la informacion de la cuenta o 9 para realizar una transaccion.");
                    seleccionado = int.Parse(Console.ReadLine());

                    if (seleccionado == verinfo)
                    {
                        Ahorros ca = new Ahorros();
                        ca.MostrarNombre();
                        ca.NumeroCuenta();
                        Console.WriteLine("Su saldo inicial es: " + ca.getSaldoInicial());
                    }

                    if (seleccionado == continuar)
                    {
                        Ahorros ca = new Ahorros();
                        int consigna = 1;
                        int retira = 2;
                        int seleccion;
                        Console.WriteLine("1 para consignar, 2 para retirar.");
                        seleccion = int.Parse(Console.ReadLine());

                        if (seleccion == consigna)
                        {
                            Console.WriteLine("Ingrese el valor a consignar: ");
                            double v = double.Parse(Console.ReadLine());
                            ca.SetSaldoConsignar(v);
                            ca.Consignar();
                            String si = "y";
                            String no = "n";
                            String opcion;
                            Console.WriteLine("¿Desea ver su saldo actual? Presione y para verlo o n para salir");
                            opcion = Console.ReadLine();

                            if (opcion == si)
                            {
                                Console.WriteLine("Su saldo despues de la consignacion es: " + ca.getSaldo());
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Salió del programa.");
                            }

                        }
                        if (seleccion == retira)
                        {
                            Console.WriteLine("Ingrese el valor a retirar: ");
                            double r = double.Parse(Console.ReadLine());
                            ca.SetSaldoRetirar(r);
                            ca.Retirar();
                            String si = "y";
                            String no = "n";
                            String opcion;
                            Console.WriteLine("¿Desea ver su saldo actual? Presione y para verlo o n para salir");
                            opcion = Console.ReadLine();

                            if (opcion == si)
                            {
                                Console.WriteLine("Su saldo despues del retiro es: " + ca.getSaldo());
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Salió del programa.");
                            }
                        }
                    }

                }

                if (selecciona == corriente)
                {
                    int verinformacion = 0;
                    int continuartransaccion = 9;
                    int selected;
                    Console.WriteLine("Seleccione 0 para ver la informacion de la cuenta o 9 para realizar una transaccion.");
                    selected = int.Parse(Console.ReadLine());

                    if (selected == verinformacion)
                    {
                        Corriente cc = new Corriente();
                        cc.MostrarNombreC();
                        cc.NumeroCuentaC();
                        Console.WriteLine("Su saldo inicial es: " + cc.getSaldoInicial());

                    }
                    if (selected == continuartransaccion)
                    {
                        Corriente cc = new Corriente();
                        int consignacion = 1;
                        int retiro = 2;
                        int eleccion;
                        Console.WriteLine("Digite 1 para consignar o 2 para retirar.");
                        eleccion = int.Parse(Console.ReadLine());

                        if (eleccion == consignacion)
                        {

                            Console.WriteLine("Ingrese el valor a consignar: ");
                            double v = double.Parse(Console.ReadLine());
                            cc.SetSaldoConsignarC(v);
                            cc.ConsignarC();
                            String yes = "y";
                            String nou = "n";
                            String opcionsele;
                            Console.WriteLine("¿Desea ver su saldo actual? Presione y para verlo o n para salir");
                            opcionsele = Console.ReadLine();

                            if (opcionsele == yes)
                            {
                                Console.WriteLine("Su saldo despues de la consignacion es: " + cc.getSaldo());
                                Console.ReadLine();

                            }
                            else
                            {
                                Console.WriteLine("Salió del programa.");
                            }

                        }
                        if (eleccion == retiro)
                        {
                            Console.WriteLine("Ingrese el valor a retirar: ");
                            double r = double.Parse(Console.ReadLine());
                            cc.SetSaldoRetirarC(r);
                            cc.RetirarC();
                            String yes = "y";
                            String nou = "n";
                            String opcionsele;
                            Console.WriteLine("¿Desea ver su saldo actual? Presione y para verlo o n para salir");
                            opcionsele = Console.ReadLine();

                            if (opcionsele == yes)
                            {
                                Console.WriteLine("Su saldo despues del retiro es: " + cc.getSaldo());
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Salió del programa.");
                            }
                        }




                    }               
            }
        }
    }
}
