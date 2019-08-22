using System;

namespace _04.pagatrabajador
{
    class Program
    {
        static void Main(string[] args)
        {   
            string nombre;
            double horas = 0, paga = 0, tasa = 0.3;
            double pagaBruta = 0, pagaExtra = 0, impuesto = 0, pagaNeta  = 0;

            Console.WriteLine("Programa que calcula la paga de un trabajador \n\n ");
            
            Console.WriteLine("Dame el nombre:");
            nombre = Console.ReadLine();

            Console.WriteLine("Dame las horas que trabaja:");
            horas = Double.Parse(Console.ReadLine());

            Console.WriteLine("Dame la paga:");
            paga = Double.Parse(Console.ReadLine());

            if (horas > 40)
            {
                pagaExtra = (horas - 40) * (paga * 2);
            }

            pagaBruta = (horas- (horas - 40)) * paga;
            pagaNeta = pagaBruta + pagaExtra;
            impuesto = pagaBruta * tasa;
            pagaNeta -= impuesto;
            Console.WriteLine($"nombre: {nombre}, paga bruta {pagaBruta}, impuesto {impuesto}, paga neta {pagaNeta}, pagaExtra {pagaExtra}");
        }
    }
}
