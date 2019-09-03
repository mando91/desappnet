
namespace ControlBancario.clases
{
    public class CuentaBancaria
    {
        protected double saldo;

        public CuentaBancaria(){}

        public CuentaBancaria(double saldo)
        {
            this.saldo = saldo;
        }

        public double Saldo
        {
            get { return saldo; }
            set { saldo += value; }
        }


        public virtual bool retirar(double cantidad) // la palabra virtual permite sobre carga
        {   
            if (cantidad < saldo)
            {
                saldo -= cantidad;
                return true;
            }

            return false;
        }
        
    }
}