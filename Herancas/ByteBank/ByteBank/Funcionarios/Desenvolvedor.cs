using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    public class Desenvolvedor : Funcionario
    {
        public  Desenvolvedor(double salario,string cpf) : base(salario,cpf)
        {
            Salario = salario;
            CPF = cpf;
        }

        public override  void AumentarSalario()
        {
            Salario = Salario + ((5 / 100) * Salario);
        }
        public override double GetBonificacao()
        {

            return Salario * 0.25;
        }
    }
}
