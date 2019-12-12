using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(double salario,string cpf) : base(salario,cpf)
        {
            Salario = salario;
            CPF = cpf;
        }

        public override void AumentarSalario()
        {
            Salario = Salario + ((10 / 100) * Salario);
        }
        public override double GetBonificacao()
        {

            return Salario * 0.20;
        }
    }
}
