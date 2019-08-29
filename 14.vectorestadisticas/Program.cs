using System;

namespace _14.vectorestadisticas
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vectorA;

            int cantElementosVector;

            Console.WriteLine("Cuantos elementos es el vector:");
            cantElementosVector = Int32.Parse(Console.ReadLine());

            vectorA = new double[cantElementosVector];

            leerElementos(vectorA);

            Console.WriteLine($"El numero mayor es:{numMayor(vectorA)}");
            Console.WriteLine($"El numero menor es:{numMenor(vectorA)}");
            Console.WriteLine($"El promedio  es:{prom(vectorA)}");
            Console.WriteLine($"la varianza es:{varianza(vectorA,prom(vectorA) )}");
            Console.WriteLine($"la DES ESTANDAR es:{Math.Sqrt( varianza(vectorA,prom(vectorA)) )}");
        }

         static double desEstandar(double[] vector, double prom)
        {
            double suma = 0;

            for (int i = 0; i < vector.Length; i++)
            {
                suma += Math.Pow( vector[i] - prom, 2);
            }

            return (suma/ vector.Length)-1;
        }

         static double varianza(double[] vector, double prom)
        {
            double suma = 0;

            for (int i = 0; i < vector.Length; i++)
            {
                suma += Math.Pow( vector[i] - prom, 2);
            }

            return (suma/ vector.Length)-1;
        }

         static double prom(double[] vector)
        {
            double suma = 0;

            for (int i = 0; i < vector.Length; i++)
            {
                suma += vector[i];
            }

            return (suma/ vector.Length);
        }

        static double numMayor(double[] vector)
        {
            double mayor = vector[0];

            for (int i = 1; i < vector.Length; i++)
            {
                if (mayor < vector[i])
                {
                    mayor = vector[i];
                }
            }

            return mayor;
        }

        static double numMenor(double[] vector)
        {
            double menor = vector[0];

            for (int i = 1; i < vector.Length; i++)
            {
                if (menor > vector[i])
                {
                    menor = vector[i];
                }
            }

            return menor;
        }

        static void leerElementos(double[] vector)
        {

            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine($"introduce el numero {i+1}");
                vector[i] = double.Parse(Console.ReadLine());
            }
        }
    }
}
