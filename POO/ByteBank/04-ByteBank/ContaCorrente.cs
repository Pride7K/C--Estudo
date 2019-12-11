public class ContaCorrente
{
    public string titular;
    public int agencia;
    public int numero;
    public double saldo = 100;

    /* função sempre com letra maiuscular na letra inicial */
    public bool Sacar(double valor)
    {
        if(this.saldo<valor)
        {
            
            return false;
        }
        else
        {
            this.saldo -= valor;
            return true;
        }
    }

    public void Depositar(double valor)
    {
        this.saldo += valor;
    }

    public bool Transferir(double valor,ContaCorrente contaDestino)
    {
        if(valor > this.saldo)
        {
            return false;
        }
        else
        {
            this.saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
   
}
