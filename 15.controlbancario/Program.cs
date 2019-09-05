using System;
using ControlBancario.clases;

namespace controlbancario
{
    class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria cuentaB1, cuentaB2;
            CuentaAhorro cuentaAhorro;
            CuentaCheque cuentaC;
            Cliente c1, c2, c3, c4;
            Banco banco;

            cuentaB1 = new CuentaBancaria();
            cuentaB2 = new CuentaBancaria(20);

            cuentaAhorro = new CuentaAhorro( 0.3, 600);
            cuentaC = new CuentaCheque(1000, 100);

            banco = new Banco("Riky Ricon de SA de  CV");

            c1 = new Cliente("Armando");
            c2 = new Cliente("Nallely");
            c3 = new Cliente("Mateo");
            c4 = new Cliente("Tere");

            cuentaB1.Saldo = 200;
            cuentaB2.retirar(10);
            cuentaAhorro.Saldo = 100;
            cuentaAhorro.retirar(100);
            cuentaC.Saldo = 100;
            cuentaC.retirar(100);

            c1.agregarCuenta(new CuentaCheque(2000, 1000));
            c2.agregarCuenta(new CuentaCheque(1000, 2000));
            c3.agregarCuenta(new CuentaCheque(3000, 3000));
            c4.agregarCuenta(new CuentaCheque(12000, 22000));
            c4.agregarCuenta(new CuentaAhorro(0.3, 12000));

            Console.WriteLine($"Cuenta 1: {cuentaB1.Saldo}");
            Console.WriteLine($"Cuenta 1: {cuentaB2.Saldo}");
            Console.WriteLine($"Cuenta 1: {cuentaAhorro.Saldo}");
            Console.WriteLine($"Cuenta 1: {cuentaC.Saldo}");

            c1.Cuentas[0].retirar(300);
            c3.Cuentas[0].Saldo = 2000;
            c4.Cuentas[1].retirar(1000);

            banco.addCliente(c1);
            banco.addCliente(c2);
            banco.addCliente(c2);
            banco.addCliente(c4);
            banco.addCliente(new Cliente("Tello"));

            banco.Clientes[4].agregarCuenta(new CuentaCheque(3000, 300));

            Console.WriteLine("---------------------------REPORTE DE CLIENTES---------------- \n");
            Console.WriteLine($"{banco.Nombre}");

            foreach(Cliente cte in banco.Clientes)
            {
                Console.WriteLine($"Clientes: {cte.Nombre}");

                foreach(CuentaBancaria cb in cte.Cuentas)
                {
                    if (cb is CuentaAhorro)
                    {
                        Console.WriteLine($"Cuenta ahorro");
                    }
                    else
                    {
                        Console.WriteLine($"Cuenta de cheques");
                    }
                    Console.WriteLine($"Saldo: {cb.Saldo}");
                }

                Console.WriteLine();
            }
        }
    }
}
