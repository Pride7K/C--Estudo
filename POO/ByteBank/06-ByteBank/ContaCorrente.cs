


namespace _06_ByteBank
{
    public class ContaCorrente
    {
  
        private double _saldo = 100;

        public int Numero { get; set; }
        public int Agencia { get; set; }

        public Cliente Titular { get; set; }

        public double Saldo { get; set; }




        public double GetSaldo()
        {
            return _saldo;
        }

        public void  SetSaldo(double saldo)
        {
            if(saldo <0)
            {
                /* Return sem nada é tipo um break para metodos */
                return;
            }
            else
            {
                this._saldo += saldo;
            }
        }

        /* função sempre com letra maiuscular na letra inicial */
        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {

                return false;
            }
            else
            {
                _saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor > _saldo)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }

        

    }
}