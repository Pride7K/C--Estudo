using System;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(867,273823);
            Cliente cliente = new Cliente();


            ContaCorrente conta2 = new ContaCorrente(867, 273823);

         
            ContaCorrente conta3 = new ContaCorrente(867, 273823);
            
            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            conta.Agencia = 4444;
            conta.Numero = 121212;

            

            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);
            Console.WriteLine(ContaCorrente._TotalContas);

        }
    }
}
