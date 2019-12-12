using System;
using System.Collections.Generic;
using System.Text;
using ByteBank.Funcionarios;

namespace ByteBank.Sistemas
{
    public interface Autenticavel
    {
        bool Autenticar(string senha);
    }
}
