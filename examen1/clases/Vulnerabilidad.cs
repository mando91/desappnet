using System;

namespace examen1.clases
{
    public class Vulnerabilidad
    {
        private string clave;
        private string vendedor;
        private string descripcion;
        private string tipo;
        private string fecha;

        public Vulnerabilidad(){}
        public Vulnerabilidad(string clave, string vendedor, string descripcion, string tipo, string fecha)
        {
            this.clave = clave;
            this.vendedor = vendedor;
            this.tipo = tipo;
            this.descripcion = descripcion;
            this.fecha = fecha;
        }

        private int calcularAntiguedad()
        {
            string[] datos;
            DateTime f1, f2;

            f1 = new DateTime();
            f2 = new DateTime();

            datos = fecha.Split("/");

            f1 = System.DateTime.Parse(datos[1] + "/" + datos[0] +"/" + datos[2]);

            f2 = System.DateTime.Today;
           // Console.WriteLine(f2.ToString());
            return f2.Year - f1.Year;
        }

        public string Clave
        {
            get {return clave;}
            set { clave = value;}
        }
        public string Vendedor
        {
            get {return vendedor;}
            set { vendedor = value;}
        }
        public string Tipo
        {
            get {return tipo;}
            set { tipo = value;}
        }
        public string Fecha
        {
            get {return fecha;}
            set { fecha = value;}
        }
        public string Descripcion
        {
            get {return descripcion;}
            set { descripcion = value;}
        }

        public void imprimir()
        {
            Console.WriteLine($"Clave: {clave}, Vendedor: {vendedor}, Descripcion: {descripcion}");
            Console.WriteLine($"Tipo: {tipo}, Fecha {fecha}, Antiguedad: {calcularAntiguedad()}");
        }
    }
}