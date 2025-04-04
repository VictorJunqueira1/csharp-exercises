namespace Calculator;

static class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();

        Console.WriteLine("O que deseja fazer?");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
        Console.WriteLine("5 - Sair");

        Console.WriteLine("======================");

        Console.WriteLine("Selecione uma opção: ");
        short option = short.Parse(Console.ReadLine());

        switch (option)
        {
            case 1: Sum(); break;
            case 2: Subtraction(); break;
            case 3: Multiplication(); break;
            case 4: Division(); break;
            case 5: Console.WriteLine("Saindo... Até logo!"); Environment.Exit(0); break;
            default: Menu(); break;
        }
    }

    static void Sum()
    {
        Console.Clear();
        Console.Write("Digite um número: ");
        float valor1 = float.Parse(Console.ReadLine());

        Console.Write("Digite outro número: ");
        float valor2 = float.Parse(Console.ReadLine());

        Console.WriteLine($"O resultado da soma é: {valor1 + valor2}");
        Console.ReadKey();
        Menu();
    }

    static void Subtraction()
    {
        Console.Clear();
        Console.Write("Digite um número: ");
        float valor1 = float.Parse(Console.ReadLine());

        Console.Write("Digite outro número: ");
        float valor2 = float.Parse(Console.ReadLine());

        Console.WriteLine($"O resultado da subtração é: {valor1 - valor2}");
        Console.ReadKey();
        Menu();
    }

    static void Multiplication()
    {
        Console.Clear();
        Console.Write("Digite um número: ");
        float valor1 = float.Parse(Console.ReadLine());

        Console.Write("Digite outro número: ");
        float valor2 = float.Parse(Console.ReadLine());

        Console.WriteLine($"O resultado da multiplicação é: {valor1 * valor2}");
        Console.ReadKey();
        Menu();
    }

    static void Division()
    {
        Console.Clear();

        Console.Write("Digite um número: ");
        float valor1 = float.Parse(Console.ReadLine());

        Console.Write("Digite outro número: ");
        float valor2 = float.Parse(Console.ReadLine());

        if (valor1 == 0 || valor2 == 0)
        {
            Console.WriteLine("Impossivel dividir por zero!");
            return;
        }

        Console.WriteLine($"O resultado da divisão é: {valor1 / valor2}");
        Console.ReadKey();
        Menu();
    }
}