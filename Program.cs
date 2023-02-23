Menu();

static void Menu()
{
    Console.Clear();

    Console.WriteLine("Escolha a operação que deseja fazer:");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Divição");
    Console.WriteLine("4 - Multiplicação");
    Console.WriteLine("0 - Sair");
    Console.WriteLine("------------------");

    int opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1: Soma(); break;
        case 2: Subtracao(); break;
        case 3: Divicao(); break;
        case 4: Multiplicacao(); break;
        case 0: System.Environment.Exit(0); break;
        default: Menu(); break;

    }
}

static void Soma()
{
    Console.Clear();
    Console.WriteLine("Digite o primeiro valor: ");
    double v1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo valor: ");
    double v2 = double.Parse(Console.ReadLine());

    double resultado = v1 + v2;

    Console.WriteLine($"Resultado é: {resultado}");

    Console.ReadKey();
    Menu();

}

static void Subtracao()
{
    Console.Clear();
    Console.WriteLine("Digite o primeiro valor: ");
    double v1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo valor: ");
    double v2 = double.Parse(Console.ReadLine());

    double resultado = v1 - v2;

    Console.WriteLine($"Resultado é: {resultado}");

    Console.ReadKey();
    Menu();

}

static void Divicao()
{
    Console.Clear();
    Console.WriteLine("Digite o primeiro valor: ");
    double v1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo valor: ");
    double v2 = double.Parse(Console.ReadLine());

    double resultado = v1 / v2;

    Console.WriteLine($"Resultado é: {resultado}");

    Console.ReadKey();
    Menu();

}

static void Multiplicacao()
{
    Console.Clear();
    Console.WriteLine("Digite o primeiro valor: ");
    double v1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo valor: ");
    double v2 = double.Parse(Console.ReadLine());

    double resultado = v1 * v2;

    Console.WriteLine($"Resultado é: {resultado}");

    Console.ReadKey();
    Menu();

}