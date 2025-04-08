using System.Text.RegularExpressions;

namespace EditorHTML;

public static class Viewer
{
    public static void Show(string text)
    {
        Console.Clear();
        Console.WriteLine("MODO DE VISUALIZAÇÃO");
        Console.WriteLine("---------------");
        Replace(text);
        Console.WriteLine("---------------");
        Console.ReadKey();
        Menu.Show();
    }

    public static void Replace(string text)
    {
        var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>", RegexOptions.IgnoreCase);

        int currentIndex = 0;
        var matches = strong.Matches(text);

        foreach (Match match in matches)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(text.Substring(currentIndex, match.Index - currentIndex));

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(match.Groups[1].Value);

            currentIndex = match.Index + match.Length;
        }

        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write(text.Substring(currentIndex));
        Console.ResetColor();
        Console.WriteLine();
    }

}