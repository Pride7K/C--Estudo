using System;
using System.Collections.Generic;
using System.Text;
using ByteBank.Sistemas;

namespace ByteBank.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        
        public Diretor(double salario,string cpf) : base(salario,cpf)
        {
            //Console.WriteLine("Criando construtor do diretor");
        }
        public override double GetBonificacao()
        {
           
            return Salario + 15;
        }

        public override void AumentarSalario()
        {
            Salario = Salario + (Salario * 0.15);
        }

        
    }

}
