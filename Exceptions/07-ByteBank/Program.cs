using System;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(32323, 23232323);

            Console.WriteLine(ContaCorrente.TaxaOperacao);

            //ContaCorrente conta2 = null;
           // Console.WriteLine(conta2.Saldo);
        }
    }
}
