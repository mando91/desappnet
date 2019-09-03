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

            cuentaB1 = new CuentaBancaria();
            cuentaB2 = new CuentaBancaria(20);
            cuentaAhorro = new CuentaAhorro( 0.3, 600);
            cuentaC = new CuentaCheque(1000, 100);

            cuentaB1.Saldo = 200;
            cuentaB2.retirar(10);
            cuentaAhorro.Saldo = 100;
            cuentaAhorro.retirar(100);
            cuentaC.Saldo = 100;
            cuentaC.retirar(100);

            Console.WriteLine($"Cuenta 1: {cuentaB1.Saldo}");
            Console.WriteLine($"Cuenta 1: {cuentaB2.Saldo}");
            Console.WriteLine($"Cuenta 1: {cuentaAhorro.Saldo}");
            Console.WriteLine($"Cuenta 1: {cuentaC.Saldo}");
        }
    }
}
