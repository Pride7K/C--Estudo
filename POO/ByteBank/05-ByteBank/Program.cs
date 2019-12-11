using System;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Cliente cliente = new Cliente();
            ContaCorrente user = new ContaCorrente();

            user.titular.nome = "Guilherme";
            user.titular.cpf = "252323232323";
            user.titular.profissao = "auxilir de desenvolvimento";

            
            try
            {
                user.titular.nome = "Guilherme";
                user.titular.cpf = "252323232323";
                user.titular.profissao = "auxilir de desenvolvimento";

                Console.WriteLine(user.titular.nome);
                Console.WriteLine(user.titular.cpf);
            }
            catch
            { 
                if (user.titular == null)
                {
                    Console.WriteLine("Cliente Nulo");

                }
            }
            user.saldo = 500;
            user.agencia = 863;
            user.numero = 678;


        }
    }
}
