using System;
using ByteBank.Funcionarios;
using ByteBank.Sistemas;
namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Program programa = new Program();

            programa.CalcularBonificacao();
            */
            CalcularBonificacao();

            UsarSistema();

            Console.ReadLine();
        }
        public static void UsarSistema()
        {
            SistemaInterno sistema = new SistemaInterno();

            Diretor marcos = new Diretor(5000, "5232323");
            marcos.Nome = "Marcos";
            marcos.Senha = "123";

            Gerente gui = new Gerente(10000, "234232");
            gui.Nome = "Guilherme";
            gui.Senha = "567";


            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "abc";

            sistema.Logar(marcos, "123");
            sistema.Logar(marcos, "1234");
            Console.WriteLine("");
            sistema.Logar(gui, "32");
            sistema.Logar(gui, "567");
            Console.WriteLine("");
            sistema.Logar(parceiro, "21343");
            sistema.Logar(parceiro, "abc");

        }
        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario pedro = new Designer(500, "52323232");
            pedro.Nome = "pedro";

            // Irá dar erro porque a clase funcionario é uma classe abstrata
            /*
            Funcionario pedro2 = new Funcionario(500, "52323232");
            pedro2.Nome = "pedro";
            */
            Funcionario marcos = new Diretor(5000, "5232323");
            marcos.Nome = "Marcos";

            Funcionario massa = new Auxiliar(1000, "2323232");
            massa.Nome = "massa";

            Funcionario gui = new Gerente(10000, "234232");
            gui.Nome = "Guilherme";

            Funcionario carlao = new Desenvolvedor(3000, "23232");
            carlao.Nome = "Carlao";

            gerenciador.Registrar(pedro);
            gerenciador.Registrar(marcos);
            gerenciador.Registrar(massa);
            gerenciador.Registrar(gui);
            Console.WriteLine(pedro.GetBonificacao());
            Console.WriteLine(marcos.GetBonificacao());
            Console.WriteLine(massa.GetBonificacao());
            Console.WriteLine(gui.GetBonificacao());
            Console.WriteLine($"Bonificação mensal foi de {gerenciador.GetTotalBonificacao()}");

        }
    }
}
