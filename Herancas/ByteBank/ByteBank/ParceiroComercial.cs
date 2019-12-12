using System;
using System.Collections.Generic;
using System.Text;
using ByteBank.Sistemas;
namespace ByteBank
{
    public class ParceiroComercial : Autenticavel
    {
        public string Senha { get; set; }
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
       
    }
}
