using System;
using System.Collections.Generic;
using System.Text;
using ByteBank.Sistemas;

namespace ByteBank.Funcionarios
{
    public class Gerente: FuncionarioAutenticavel
    {
        
        public Gerente(double salario,string cpf) : base(salario,cpf)
        {
            Salario = salario;
            CPF = cpf;
        }
        public override void AumentarSalario()
        {
            Salario = Salario + ((5 / 100) * Salario);
        }
        public override double GetBonificacao()
        {

            return Salario * 0.25;
        }
       
    }
}
