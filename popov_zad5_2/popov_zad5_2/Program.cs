using System;

class Program
{
    static void Main()
    {
        // Объявление переменных для символов
        char char1, char2;

        // Ввод первого символа с проверкой
        Console.Write("Введите первый символ: ");
        if (!char.TryParse(Console.ReadLine(), out char1))
        {
            Console.WriteLine("Ошибка: некорректный ввод первого символа.");
            return;
        }
        Console.WriteLine();

        // Ввод второго символа с проверкой
        Console.Write("Введите второй символ: ");
        if (!char.TryParse(Console.ReadLine(), out char2))
        {
            Console.WriteLine("Ошибка: некорректный ввод второго символа.");
            return;
        }
        Console.WriteLine();

        // Если ASCII-код первого символа больше ASCII-кода второго, выполняется обмен
        if (char1 > char2)
        {
            char temp = char1;
            char1 = char2;
            char2 = temp;
            Console.WriteLine($"После обработки: первый символ - {char1}, второй символ - {char2}");
        }
        else
        {
            Console.WriteLine("Обмена не требуется, порядок символов корректный.");
            Console.WriteLine($"Первый символ - {char1}, второй символ - {char2}");
        }

        // Ожидание нажатия клавиши для завершения программы
        Console.ReadKey(true);
    }
}
