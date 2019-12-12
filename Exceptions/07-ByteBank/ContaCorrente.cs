using System;

namespace _07_ByteBank
{
    public class ContaCorrente
    {
        public static double TaxaOperacao { get; private set; }

        private double _saldo = 100;

        private int _agencia;

        public static int _TotalContas { get; private set; }

        

        public int Numero { get; set; }
        public int Agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }
                _agencia = value;
            }
        }

        

        public Cliente Titular { get; set; }

        public double Saldo { get; set; }

        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;
            try
            {
            TaxaOperacao = 30 / _TotalContas;
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Tentativa de dividir numero por zero");
            }
            _TotalContas++;

         
        }

         

        public double GetSaldo()
        {
            return _saldo;
        }

        public void SetSaldo(double saldo)
        {
            if (saldo < 0)
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