using System;

namespace _03.areatriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que calcula el area de un triangulo");

            double area, baseT, altura;
            if (args.Length < 2)
            {
                Console.WriteLine("Forma de uso:");
                Console.WriteLine("dotnet run <base> <altura>");
               // Environment.Exit(0);
            }else{
                baseT = Double.Parse(args[0]);
                altura = Double.Parse(args[1]);
                area = (baseT * altura) /2;
                Console.WriteLine($"el area es: {area}");
            }
        }
    }
}
