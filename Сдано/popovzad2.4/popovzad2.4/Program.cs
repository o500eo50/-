using System;

class Program
{
    static void Main()
    {
        // Исходная строка с ошибками
        string text = "Веръшины, пятынистые, сеедой, порялдели, очищають, трясеёт, приппекает, помешарть";

        // Исправление текста с использованием Remove() и вставки исправлений
        // Удаление 'ъ'
        int index = text.IndexOf("ъ");
        while (index != -1)
        {
            text = text.Remove(index, 1);
            index = text.IndexOf("ъ");
        }

        // Исправление "еедой" -> "едой"
        index = text.IndexOf("еед");
        if (index != -1)
        {
            text = text.Remove(index, 1); // Удаляем один лишний 'е'
        }

        // Исправление "порялдели" -> "пордели"
        index = text.IndexOf("ря");
        if (index != -1)
        {
            text = text.Remove(index, 1); // Удаляем 'я'
        }

        // Исправление "очищають" -> "очищают"
        index = text.IndexOf("яь");
        if (index != -1)
        {
            text = text.Remove(index + 1, 1); // Удаляем 'ь'
        }

        // Исправление "трясёёт" -> "трясёт"
        index = text.IndexOf("её");
        if (index != -1)
        {
            text = text.Remove(index, 1); // Удаляем одну 'е'
        }

        // Исправление "приппекает" -> "припекает"
        index = text.IndexOf("пп");
        if (index != -1)
        {
            text = text.Remove(index, 1); // Удаляем один 'п'
        }

        // Исправление "помешарть" -> "помешать"
        index = text.IndexOf("шарть");
        if (index != -1)
        {
            text = text.Remove(index + 4, 1).Insert(index + 4, "а"); // Заменяем 'р' на 'а'
        }

        // Вывод исправленной строки
        Console.WriteLine(text);
        Console.ReadKey();
    }
}
