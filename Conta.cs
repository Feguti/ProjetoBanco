public class Conta
{
    public int Codigo { get; set; }
    public double Saldo { get; private set; }

    public Conta(int codigo)
    {
        Codigo = codigo;
        Saldo = 0.0;
    }
    public void Sacar(double valor)
    {
        ValidarValor(valor);
        VerificarSaldo(valor);

            Saldo -= valor;
    }

    public void Depositar(double valor)
    {
        ValidarValor(valor);

        Saldo += valor;
    }

    public void Transferir(Conta conta, double valor)
    {
        ValidarValor(valor);
        VerificarSaldo(valor);

        Sacar(valor);
        conta.Depositar(valor);

    }

    private void ValidarValor(double valor)
    {
        if(valor <= 0.0) throw new ArgumentException("O valor precisa ser maior do que 0");
    }

    private void VerificarSaldo(double valor)
    {
        if(valor > Saldo) throw new ArgumentException("Saldo insuficiente");
    }

}