using System.Collections.Generic;
using System;

namespace examen1.clases
{
    public class Red
    {
        private List<Nodo> nodos;
        private string propetario;
        private string empresa;
        private string domicilio;

        public Red(string propetario, string empresa, string domicilio)
        {
            this.propetario = propetario;
            this.empresa = empresa;
            this.domicilio = domicilio;
            nodos = new List<Nodo>();
        }
        
        private int totalNodos()
        {
            return nodos.Count;
        }

        public void addNodo(Nodo nodo){
            nodos.Add(nodo);
        }

        private int totalVul()
        {
            int cont1 = 0;

            foreach (Nodo n in nodos)
            {
                cont1 = cont1 + n.totalVulns();
            }

            return cont1;
        }
        public void imprimir()
        {
            Console.WriteLine(">> RED");
            Console.WriteLine($"Empresa: {empresa}");
            Console.WriteLine($"Propetario: {propetario}");
            Console.WriteLine($"Domicilio {domicilio}");
            Console.WriteLine();
            Console.WriteLine($"Total nodos: {totalNodos()}");
            Console.WriteLine($"Total vulnerabilidades: {totalVul()}");
            Console.WriteLine("\n");
        }

        public void imprimirNodos()
        {
            int numMayorSaltos = 0;
            int numMenorSaltos = 10000;
            Console.WriteLine(">> Datos generales de los nodos \n");
             foreach (Nodo n in nodos)
            {
                int s = int.Parse(n.Saltos);
                if (s > numMayorSaltos)
                {
                    numMayorSaltos = s;
                }

                if (s < numMenorSaltos)
                {
                    numMenorSaltos = s;
                }
                n.imprimir();
                Console.WriteLine("-------------------------------------------------------------");
            }
            Console.WriteLine();
            Console.WriteLine($"Numero mayor de saltos: {numMayorSaltos}");
            Console.WriteLine($"Numero menor de saltos: {numMenorSaltos}");
            Console.WriteLine("\n");
        }

        public void imprimirVulPorNodo()
        {
            Console.WriteLine(">> Vulnerabilidades por nodo \n");
            foreach (Nodo n in nodos)
            {
                Console.WriteLine($"> Ip: {n.Ip}, Tipo: {n.Tipo}");
                Console.WriteLine();
                
                if (n.totalVulns() > 0)
                {
                    Console.WriteLine("-Vulnerabilidades: \n");
                    foreach (Vulnerabilidad v in n.Vulnerabilidades)
                    {
                        v.imprimir();
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("No tiene vulnerabilidades ...");
                }
                Console.WriteLine("------------------------------------------------------------------------------------------");
            }
        }

    }
}