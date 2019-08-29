using System;

namespace _09.vectoresalatoreo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vectorA, vectorB, vectorC;

            vectorA = new int[15];
            vectorB = new int[15];
            vectorC = new int[15];

            Random rnd = new Random();

            for (int i = 0; i < 15; i++)
            {
                vectorA[i] = rnd.Next(1, 30);
                vectorB[i] = rnd.Next(1, 30);
                vectorC[i] = vectorA[i] + vectorB[i];
            }

            Console.WriteLine("El vector A es:");
            imprimir(vectorA);
            Console.WriteLine("El vector B es:");
            imprimir(vectorB);
            Console.WriteLine("El vector C es:");
            imprimir(vectorC);

        }

        static void imprimir(int[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
