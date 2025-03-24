class Titular
{
    public Titular(string nome, string cpf, int idade)
    {
        Nome = nome;
        Cpf = cpf;
        Idade = idade;
    }

    public string Nome { get; }
    public string Cpf { get; }
    public int Idade { get; }
}