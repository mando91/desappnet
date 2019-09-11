using System;
using examen1.clases;

namespace examen1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Vulnerabilidad vulnerabilidad1;
            Vulnerabilidad vulnerabilidad2;
            Vulnerabilidad vulnerabilidad3;
            Vulnerabilidad vulnerabilidad4;
            Vulnerabilidad vulnerabilidad5;
            Vulnerabilidad vulnerabilidad6;

            Nodo nodo1;
            Nodo nodo2;
            Nodo nodo3;
            Nodo nodo4;

            Red red;

            vulnerabilidad1 = new Vulnerabilidad("CVE-2015-1635", "microsoft", "HTTP.sys permite a atacantes remotos ejecutar código arbitrario",
                "remota", "04/14/2015");
            vulnerabilidad2 = new Vulnerabilidad("CVE-2017-0004","microsoft","El servicio LSASS permite causar una denegación de servicio",
            "local","01/10/2018"); 
            vulnerabilidad3 = new Vulnerabilidad("CVE-2017-3847","cisco","Cisco Firepower Management CenterXSS ",
            "remota","02/21/2017");
            vulnerabilidad4 = new Vulnerabilidad("CVE-2009-2504","microsoft","Múltiples desbordamientos deenteros en APIs Microsoft .NET 1.1",
            "local","11/13/2009");
            vulnerabilidad5 = new Vulnerabilidad("CVE-2016-7271","microsoft","Elevación de privilegios Kernel Segura en Windows 10 Gold",
            "local","12/20/2016");
            vulnerabilidad6 = new Vulnerabilidad(" CVE-2017-2996","adobe","Adobe Flash Player 24.0.0.194corrupción de memoria explotable",
            "remota","02/15/2017");

            nodo1 = new Nodo("192.168.0.10","servidor","5"," 10","linux");
            nodo2 = new Nodo("192.168.0.12","equipoactivo","2","12","ios");
            nodo3 = new Nodo("192.168.0.20","computadora","8","5","windows");
            nodo4 = new Nodo("192.168.0.15","servidor","10","22","linux");

            red = new Red(" Red Patito, S.A. de C.V.","Mr Pato Macdonald","Av. Princeton 123, Orlando Florida");

            nodo1.addVulnerabilidad(vulnerabilidad1);
            nodo1.addVulnerabilidad(vulnerabilidad2);
            nodo2.addVulnerabilidad(vulnerabilidad3);
            nodo3.addVulnerabilidad(vulnerabilidad4);
            nodo3.addVulnerabilidad(vulnerabilidad5);
            nodo3.addVulnerabilidad(vulnerabilidad6);


            red.addNodo(nodo1);
            red.addNodo(nodo2);
            red.addNodo(nodo3);
            red.addNodo(nodo4);
            
            red.imprimir();
            red.imprimirNodos();
            red.imprimirVulPorNodo();
        }
    }
}
