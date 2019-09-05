using System.Collections.Generic;

namespace ControlBancario.clases
{
    public class Cliente
    {
        private string nombre;
        private List<CuentaBancaria> cuentas;

        public Cliente(string nombre)
        {
            this.nombre = nombre;
            cuentas = new List<CuentaBancaria>();
        }

        public string Nombre
        {
            get {return nombre;}
            set { nombre = value;}
        }

        public List<CuentaBancaria> Cuentas
        {
            get {return cuentas;}
        }

        public void agregarCuenta(CuentaBancaria cb)
        {
            cuentas.Add(cb);
        }

    }
}