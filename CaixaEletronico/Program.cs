Console.WriteLine("Simulador de Banco\n");

Console.Write("Olá! Qual o seu nome? ");
string nomeUsuario = Console.ReadLine()!;

Console.Write("Qual o saldo inicial do seu banco? R$ ");
double saldo = double.Parse(Console.ReadLine()!);

Console.WriteLine("\nCerto! Um instante...");
Thread.Sleep(3000);

Console.Clear();

ExibirMenu();

void ExibirMenu()
{
    Console.WriteLine($"Olá {nomeUsuario}, bem-vindo! O que deseja fazer hoje?\n");

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
            EfetuarSaque();
            break;
        case '2':
            EfetuarDeposito();
            break;
        case '3':
            VerificarSaldo();
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

void EfetuarSaque()
{
    Console.Clear();
    Console.Write("Quantos reais você deseja sacar? R$ ");
    double valorSaque = double.Parse(Console.ReadLine()!);

    Console.WriteLine("\nAguarde enquanto tentamos realizar o saque...");
    Thread.Sleep(3000);

    if (saldo < valorSaque)
    {
        Console.WriteLine("\nNão é possível realizar o saque pois você não possui saldo suficiente na sua conta.");
        Console.WriteLine("\nPressione qualquer tecla para retornar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();
    }
    else
    {
        saldo -= valorSaque;
        Console.WriteLine("\nSaque realizado com sucesso!");
        Console.WriteLine("\nPressione qualquer tecla para retornar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();
    }
}

void EfetuarDeposito()
{
    Console.Clear();
    Console.Write("Quantos reais você deseja depositar? R$ ");
    double valorDeposito = double.Parse(Console.ReadLine()!);

    Console.WriteLine("Aguarde enquanto realizamos o depósito...");
    Thread.Sleep(3000);

    saldo += valorDeposito;
    Console.WriteLine("\nDepósito realizado com sucesso!");
    Console.WriteLine("\nPressione qualquer tecla para retornar ao menu principal.");
    Console.ReadKey();
    Console.Clear();
    ExibirMenu();
}

void VerificarSaldo()
{
    Console.Clear();
    Console.WriteLine("Verificando saldo...");
    Thread.Sleep(2000);

    Console.Clear();

    Console.WriteLine($"Saldo na conta: R$ {saldo}");

    Console.WriteLine("\nPressione qualquer tecla para retornar ao menu principal.");
    Console.ReadKey();
    Console.Clear();
    ExibirMenu();
}
