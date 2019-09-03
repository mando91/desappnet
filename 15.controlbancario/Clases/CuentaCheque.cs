
namespace ControlBancario.clases 
{
    public class CuentaCheque : CuentaBancaria
    {
        private double sobreGiro;

        public CuentaCheque(double saldo, double sobreGiro) : base(saldo)
        {
            this.sobreGiro = sobreGiro;
        }

        public override bool retirar(double cantidad)
        {
            if (cantidad < saldo)
            {
                saldo -= cantidad;
                return true;
            }
            
            if (cantidad < (saldo + sobreGiro))
            {
                saldo = 0;
                sobreGiro -= sobreGiro - (cantidad- saldo); 
                return true;   
            }

            return false;
        }
    }
}