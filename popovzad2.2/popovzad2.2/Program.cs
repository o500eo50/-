using System;

class Program
{
    static void Main()
    {
        // Объявление переменных
        string GUP = "Руки";
        string Mos = "по";
        string Gor = "бо";
        string Trans = "рют";
        int predlagaet = 1;
        char voditelyam = ',';
        string khorosho = "знание";
        char oplachivaemuyu = '-';
        int rabotu = 1000;

        // Формирование строки с использованием интерполяции
        Console.WriteLine($"{GUP} {Mos}{Gor}{Trans} {predlagaet}{voditelyam} {khorosho} {oplachivaemuyu} {rabotu}");
    }
}
