using System; // Подключение стандартной библиотеки System

class Program
{
    static void Main(string[] args)
    {
        // Запрос ввода от пользователя
        Console.WriteLine("Введите кириллический символ (один):");
        char symbol = '\0'; // Инициализация переменной символа

        // Проверка корректности ввода символа
        if (char.TryParse(Console.ReadLine(), out symbol))
        {
            // Использование оператора switch для обработки символа
            switch (symbol)
            {
                case 'А': // Если символ 'А'
                    Console.WriteLine("A"); // Транслитерация
                    break;
                case 'Б': // Если символ 'Б'
                    Console.WriteLine("B");
                    break;
                case 'В':
                    Console.WriteLine("V");
                    break;
                case 'Г':
                    Console.WriteLine("G");
                    break;
                case 'Д':
                    Console.WriteLine("D");
                    break;
                case 'Е':
                    Console.WriteLine("E");
                    break;
                case 'Ё':
                    Console.WriteLine("Yo");
                    break;
                case 'Ж':
                    Console.WriteLine("Zh");
                    break;
                case 'З':
                    Console.WriteLine("Z");
                    break;
                case 'И':
                    Console.WriteLine("I");
                    break;
                case 'Й':
                    Console.WriteLine("Y");
                    break;
                case 'К':
                    Console.WriteLine("K");
                    break;
                case 'Л':
                    Console.WriteLine("L");
                    break;
                case 'М':
                    Console.WriteLine("M");
                    break;
                case 'Н':
                    Console.WriteLine("N");
                    break;
                case 'О':
                    Console.WriteLine("O");
                    break;
                case 'П':
                    Console.WriteLine("P");
                    break;
                case 'Р':
                    Console.WriteLine("R");
                    break;
                case 'С':
                    Console.WriteLine("S");
                    break;
                case 'Т':
                    Console.WriteLine("T");
                    break;
                case 'У':
                    Console.WriteLine("U");
                    break;
                case 'Ф':
                    Console.WriteLine("F");
                    break;
                case 'Х':
                    Console.WriteLine("Kh");
                    break;
                case 'Ц':
                    Console.WriteLine("Ts");
                    break;
                case 'Ч':
                    Console.WriteLine("Ch");
                    break;
                case 'Ш':
                    Console.WriteLine("Sh");
                    break;
                case 'Щ':
                    Console.WriteLine("Shch");
                    break;
                case 'Ы':
                    Console.WriteLine("Y");
                    break;
                case 'Э':
                    Console.WriteLine("E");
                    break;
                case 'Ю':
                    Console.WriteLine("Yu");
                    break;
                case 'Я':
                    Console.WriteLine("Ya");
                    break;
                default: // Если символ не поддерживается
                    Console.WriteLine("Ошибка! Введите кириллический символ.");
                    break;
            }
        }
        else
        {
            // Обработка некорректного ввода
            Console.WriteLine("Ошибка! Введите кириллический символ.");
        }
    }
}