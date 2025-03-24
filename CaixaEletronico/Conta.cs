class Conta
{
    public Conta(double saldo, int agencia, int numeroConta, Titular titular)
    {
        Saldo = saldo;
        Agencia = agencia;
        NumeroConta = numeroConta;
        Titular = titular;
    }

    public double Saldo { get; private set; }
    public int Agencia { get; }
    public int NumeroConta { get; }
    public Titular Titular { get; }

    public void RealizarSaque(double valor)
    {
        if (Saldo < valor)
        {
            Console.WriteLine("\nNão é possível realizar o saque pois você não possui saldo o suficiente para isso.");
        }
        else
        {
            Saldo -= valor;
            Console.WriteLine("\nSaque realizado com sucesso!");
        }
    }
    public void RealizarDeposito(double valor)
    {
        Saldo += valor;
        Console.WriteLine("\nDepósito realizado com sucesso!");
    }
    public void ExibirSaldo()
    {
        Console.WriteLine($"Saldo na conta: R$ {Saldo}");
    }
}