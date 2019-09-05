using System.Collections.Generic;

namespace ControlBancario.clases
{
    public class Banco
    {
        private string nombre;
        private List<Cliente> clientes;

        public Banco(string nombre)
        {
            this.nombre = nombre;
            clientes = new List<Cliente>();
        }

        public string Nombre
        {
            get {return nombre;}
            set { nombre = value;}
        }

        public List<Cliente> Clientes
        {
            get {return clientes;}
        }

        public void addCliente(Cliente c)
        {
            clientes.Add(c);
        }
    }
}