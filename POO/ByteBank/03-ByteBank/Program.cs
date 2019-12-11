using System;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.titular = "Guilherme";
            conta.agencia = 863;
            conta.numero = 863452;

            ContaCorrente conta3 = new ContaCorrente();

            conta3.titular = "Guilherme";
            conta3.agencia = 863;
            conta3.numero = 863452;

            ContaCorrente conta2 = new ContaCorrente();

            conta2.titular = "Guilherme";
            conta2.agencia = 863;
            conta2.numero = 863452;



            Console.WriteLine($" Igualde de tipo de referencia {(conta == conta2)}");

            Console.WriteLine(conta3 == conta);

            Console.WriteLine(conta.titular == conta3.titular);

            Console.WriteLine($" Igualde de tipo de referencia {(conta == conta3)}");

            conta = conta3;

            Console.WriteLine($" Igualde de tipo de referencia {(conta == conta3)}");

            conta3.saldo = 300;

            Console.WriteLine(conta.saldo);

            Console.WriteLine(conta3.saldo);

        }
    }
}
