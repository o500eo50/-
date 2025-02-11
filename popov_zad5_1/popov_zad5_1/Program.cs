using System;

class Program
{
    static void Main()
    {
        // Объявление переменных для исходных данных и результатов
        double n, b, a, m, Z;
        bool isValid = true; // Флаг проверки корректности ввода

        // Ввод значения n с проверкой
        Console.Write("Введите число n: ");
        isValid &= double.TryParse(Console.ReadLine(), out n);
        Console.WriteLine();

        // Ввод значения b с проверкой
        Console.Write("Введите число b: ");
        isValid &= double.TryParse(Console.ReadLine(), out b);
        Console.WriteLine();

        // Ввод значения a с проверкой
        Console.Write("Введите число a: ");
        isValid &= double.TryParse(Console.ReadLine(), out a);
        Console.WriteLine();

        // Проверка корректности ввода всех данных
        if (isValid)
        {
            // Вычисление m в зависимости от значения b
            if (b > 4)
            {
                m = Math.Pow(n, 2); // m = n²
            }
            else
            {
                m = Math.Pow(n, 2) * Math.Cos(n); // m = n² * cos(n)
            }

            // Вычисление Z в зависимости от значения m
            if (m > 9)
            {
                Z = Math.Pow(a, 2) * Math.Cos(m); // Если m > 9, Z = a² * cos(m)
            }
            else if (m < 9)
            {
                Z = m + a; // Если m < 9, Z = m + a
            }
            else // m == 9
            {
                Z = Math.Sqrt(Math.Pow(m, 2) + a); // Если m = 9, Z = sqrt(m² + a)
            }

            // Вывод результата вычислений
            Console.WriteLine($"Рассчитанное значение Z: {Z}");
        }
        else
        {
            Console.WriteLine("Ошибка: некорректный ввод данных.");
        }

        // Ожидание нажатия клавиши для завершения программы
        Console.ReadKey(true);
    }
}
