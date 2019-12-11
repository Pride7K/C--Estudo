using System;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Console.WriteLine(conta.Sacar(30));
            Console.WriteLine(conta.saldo);

            conta.Depositar(500);
            Console.WriteLine(conta.saldo);

            ContaCorrente conta2 = new ContaCorrente();
            conta2.titular = "Guilherme";

            Console.WriteLine(conta2.Transferir(90, conta));

            Console.WriteLine(conta.saldo);
            Console.WriteLine(conta2.saldo);

            Console.WriteLine(conta.Transferir(600, conta2));

            Console.WriteLine(conta.saldo);
            Console.WriteLine(conta2.saldo);
        }
    }
}
