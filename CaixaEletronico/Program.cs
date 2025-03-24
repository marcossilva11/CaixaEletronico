Console.WriteLine("Simulador de Banco\n");

Console.WriteLine("Olá! Para começar , precisamos de algumas informações suas, vamos lá? ");
Console.Write("Primeiro, qual o seu nome? ");
string nomeUsuario = Console.ReadLine()!;

Console.Write("\nÓtimo, agora qual o seu CPF? ");
string cpf = Console.ReadLine()!;

Console.Write("\nMuito bem, qual sua idade? ");
int idade = int.Parse(Console.ReadLine()!);

Console.Write("Agora, por fim, qual o saldo inicial do seu banco? R$ ");
double saldo = double.Parse(Console.ReadLine()!);

Console.Clear();

Console.WriteLine("\nCerto! Aguarde um instante enquanto processamos suas informações...");
Thread.Sleep(5000);

Console.Clear();

Titular usuario = new(nomeUsuario, cpf, idade);
Conta conta = new(saldo, 1, 1, usuario);

ExibirMenu();

void ExibirMenu()
{
    Console.WriteLine($"Olá {usuario.Nome}, bem-vindo! O que deseja fazer hoje?\n");

    Console.WriteLine("***************************");
    Console.WriteLine("1. Realizar saque");
    Console.WriteLine("2. Realizar depósito");
    Console.WriteLine("3. Verificar saldo no banco");
    Console.WriteLine("4. Sair do banco");
    Console.WriteLine("***************************");

    char opcao = char.Parse(Console.ReadLine()!);

    switch (opcao)
    {
        case '1':
            Console.Clear();
            Console.Write("Quantos reais você deseja sacar? R$ ");
            double valorSaque = double.Parse(Console.ReadLine()!);
            Console.WriteLine("\nAguarde enquanto tentamos realizar o saque...");
            Thread.Sleep(3000);
            conta.RealizarSaque(valorSaque);
            RetornarAoMenu();
            break;
        case '2':
            Console.Clear();
            Console.Write("Quantos reais você deseja depositar? R$ ");
            double valorDeposito = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Aguarde enquanto realizamos o depósito...");
            Thread.Sleep(3000);
            conta.RealizarDeposito(valorDeposito);
            RetornarAoMenu();
            break;
        case '3':
            Console.Clear();
            Console.WriteLine("Verificando saldo...");
            Thread.Sleep(2000);
            Console.Clear();
            conta.ExibirSaldo();
            RetornarAoMenu();
            break;
        case '4':
            Console.WriteLine("\nObrigado por utilizar o programa, até a próxima!");
            Thread.Sleep(2000);
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}

void RetornarAoMenu()
{
    Console.WriteLine("\nPressione qualquer tecla para retornar ao menu principal.");
    Console.ReadKey();
    Console.Clear();
    ExibirMenu();
}
