using System;

class Program
{
    static void Main()
    {
        // Исходная строка с ошибками
        string text = "Веръшины, пятынистые, сеедой, порялдели, очищають, трясеёт, приппекает, помешарть";

        // Замена опечаток с использованием Remove() и исправление текста
        text = text.Replace("ъ", "").Replace("еед", "ед").Replace("ря", "ре").Replace("яь", "я").Replace("её", "ет");
        text = text.Replace("пп", "п").Replace("шарть", "шать");

        // Вывод исправленной строки
        Console.WriteLine(text);
    }
}
