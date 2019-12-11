using System;
using ByteBank.Funcionarios;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario(1);
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();




            funcionario.Nome = "Guilherme";
            funcionario.CPF = "2312321";
            funcionario.Salario = 5000;

            gerenciador.Register(funcionario);

            Console.WriteLine(funcionario.Nome);
            Console.WriteLine();
            Console.WriteLine();

            Diretor diretor = new Diretor();

            diretor.Nome = "Gui";
            diretor.CPF = "231232123";
            diretor.Salario = 100000;

            gerenciador.Register(diretor);

            Console.WriteLine(diretor.Nome);
            Console.WriteLine();
        }
    }
}
