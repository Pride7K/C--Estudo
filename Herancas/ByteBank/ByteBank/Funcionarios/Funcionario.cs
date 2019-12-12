using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public static int TotalFuncionarios { get; private set; }
        public string CPF { get; protected set; }

        public double Salario { get; protected set; }

        public Funcionario(double salario,string cpf)
        {
            CPF = cpf;
            Salario = salario;
            //Console.WriteLine("Criando construtor do funcionario");
            TotalFuncionarios++;
        }

        
        public abstract void AumentarSalario();


        public abstract double GetBonificacao();
        
            
    }
}
