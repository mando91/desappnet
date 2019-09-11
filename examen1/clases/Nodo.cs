using System.Collections.Generic;
using System;

namespace examen1.clases
{
    public class Nodo
    {
        private List<Vulnerabilidad> vulnerabilidades;
        private string ip;
        private string tipo;
        private string puertos;
        private string saltos;
        private string so;

        public Nodo(string ip, string tipo, string puertos, string saltos, string so)
        {
            this.ip = ip;
            this.tipo = tipo;
            this.puertos = puertos;
            this.saltos = saltos;
            this.so = so;
            vulnerabilidades = new List<Vulnerabilidad>();
        }

        public string Ip
        {
            get {return ip;}
        }

        public string Tipo
        {
            get{return tipo;}
        }

        public string Saltos
        {
            get {return saltos;}
        }

        public void addVulnerabilidad(Vulnerabilidad v)
        {
            vulnerabilidades.Add(v);
        }

        public List<Vulnerabilidad> Vulnerabilidades
        {
            get {return vulnerabilidades;}
        }

        public int totalVulns(){
            return vulnerabilidades.Count;
        }

        public void  imprimir()
        {
            Console.WriteLine($"IP: {ip}, Tipo: {tipo}, Puertos: {puertos}, Saltos: {saltos},");
            Console.WriteLine($"So: {so}, TotalVul: {totalVulns()} ");
        }
    }
}