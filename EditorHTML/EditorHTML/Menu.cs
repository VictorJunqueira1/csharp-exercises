namespace EditorHTML;

public static class Menu
{
    public static void Show()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Black;
        
        DrawScreen();
        WriteOptions();
        
        var option = short.Parse(Console.ReadLine());
        HandleMenuOptions(option);
    }

    public static void DrawScreen()
    {
        Console.Write("+");
        for (int i = 0; i < 30; i++)
            Console.Write("-");
        Console.WriteLine("+");

        for (int lines = 0; lines < 10; lines++)
        {
            Console.Write("|");
            for (int i = 0; i < 30; i++)
                Console.Write(" ");
            Console.WriteLine("|");
        }

        Console.Write("+");
        for (int i = 0; i < 30; i++)
            Console.Write("-");
        Console.WriteLine("+");
    }

    public static void WriteOptions()
    {
        Console.SetCursorPosition(3, 1);
        Console.WriteLine("Editor HTML");
        
        Console.SetCursorPosition(3, 2);
        Console.WriteLine("====================");
        
        Console.SetCursorPosition(3, 3);
        Console.WriteLine("Selecione uma opção abaixo");
        
        Console.SetCursorPosition(3, 5);
        Console.WriteLine("1 - Novo arquivo");
        
        Console.SetCursorPosition(3, 6);
        Console.WriteLine("0 - Sair");
        
        Console.SetCursorPosition(3, 8);
        Console.Write("Opção: ");
    }

    public static void HandleMenuOptions(short option)
    {
        switch (option)
        {
            case 1: Editor.Show(); break;
            case 2: Editor.Start(); break;
            case 0:
                {
                    Console.Clear();
                    Console.WriteLine("Saindo...");
                    Environment.Exit(0);
                    break;
                }
            default: Menu.Show(); break;
        }
    }
}