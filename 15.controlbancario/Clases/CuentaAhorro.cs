using ControlBancario.clases;

namespace ControlBancario.clases
{
    public class CuentaAhorro : CuentaBancaria
    {
        private double tasa;

        // base() es el constructor padre
        public CuentaAhorro(double tasa, double saldo) : base(saldo)
        {
            this.tasa = tasa;
        }
    }
}