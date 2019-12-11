using System;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.saldo = 18;

            conta.saldo += 82;

            conta.titular = "Gui";

            Console.WriteLine($"Nome de titular é {conta.titular}");

            Console.WriteLine($"O saldo da conta é de {conta.saldo}");

            Console.ReadLine();
        }
    }
}
