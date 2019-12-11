using System;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente = new Cliente();

            cliente.Nome = "Guilherme";
            cliente.Cpf = "2582392323";
            cliente.Profissao = "Auxiliar em desenvolvimento";

            conta.Titular = cliente;
           
            /*
            conta.SetSaldo(100);

            Console.WriteLine(conta.GetSaldo());
            */

            conta.Saldo = 10;

            Console.WriteLine(cliente.Nome);
            Console.WriteLine(cliente.Cpf);
            Console.WriteLine(conta.Titular.Profissao);

            Console.WriteLine(conta.Saldo);
            Console.ReadLine();
        }
    }
}
