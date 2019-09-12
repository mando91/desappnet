using System;
using Interfaces.clases;
using System.Collections.Generic;

namespace _16.Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejemplo de Interfaces \n\n");

            Box box = new Box(true, "Red", "none", 45, 60);
            List<Box> bag = FillBag();
            bag.Add(box);

            foreach (Box box1 in bag)
            {
                Console.WriteLine($"Estate: {(box1.IsOpen ? "Open": "Close")}");
                Console.WriteLine($"Color: {box1.Color}");
                Console.WriteLine($"Content: {box1.ShowContent}");
                Console.WriteLine(box1.Measure());
                Console.WriteLine();
            }
        }

        static List<Box> FillBag()
        {
            List<Box> bag = new List<Box>();
            Random rnm = new Random();

            for (int i = 0; i < 10; i++)
            {
                bag.Add(new Box(false, "Blue", "toy", rnm.Next(1,100), rnm.Next(1,100)));
            }
            return bag;
        }
    }
}
