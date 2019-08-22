using System;

namespace _02.areacirculo
{
    class Program
    {
        static void Main(string[] args)
        {   
            double radio = 0, area = 0; 

            Console.Clear();
            Console.WriteLine("Programa que calcula el area de un ciculo");
            Console.WriteLine("Dame el radio");
            radio = double.Parse(Console.ReadLine());
            area = Math.PI + Math.Pow(radio,2);

            Console.Write($"El area es {area}");
        }
    }
}
