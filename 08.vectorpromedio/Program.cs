using System;

namespace _08.vectorpromedio
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = {
                10, 20, 30 , 40 ,50 ,60 ,70, 80, 90 ,100,
                10, 20, 30 , 40 ,50 ,60 ,70, 80, 90 ,100,
                10, 20, 30 , 40 ,50 ,60 ,70, 80, 90 ,100,
                10, 20, 30 , 40 ,50 ,60 ,70, 80, 90 ,100,
                10, 20, 30 , 40 ,50 ,60 ,70, 80, 90 ,100       
            };

            int sumea = 0, contNumMayoresProm = 0;
            double prom = 0; 

            Console.WriteLine("Los elementos del arreglo son:");
            for (int i = 0; i < vector.Length; i++)
            {
                sumea += vector[i];
                Console.Write(vector[i] + " ");
            }

            prom = sumea / vector.Length;

            Console.WriteLine($"\n El promedio es:{prom}");

             for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] > prom)
                {
                    contNumMayoresProm++;
                }
            }

            Console.WriteLine($"\n La cantidad de numeros mayoes el prom es:{contNumMayoresProm}");
        }
    }
}
