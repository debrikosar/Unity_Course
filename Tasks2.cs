using System;
using System.Numerics;

class Program
{
    public static void Main()
    {
        // #1. Дан массив, необходимо заполнить его значениями от 0 до 999 и найти произведение всех нечетных элементов
        int[] numbers = new int[1000];

        BigInteger oddMultiplication = 1;
        bool isOdd = false;

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i;
            if (isOdd)
                oddMultiplication *= numbers[i];
            isOdd = !isOdd;
        }

        Console.WriteLine("1#\nПроизведение нечетных элементов массива: " + oddMultiplication);

        // #2. Дан массив символов, необходимо преобразовать его в строку
        char[] symbols = new char[] { 'd', 'o', 'n', 'e' };

        string word = new string(symbols);

        Console.WriteLine("\n2#\nСтрока полученная из массива символов: " + word);

        // #3. Даны 2 строки, необходимо зеркально отразить каждую строку и вывести в консоль друг за другом
        string first = "llaF";
        string second = "tuo";

        string reverseFirst = "";
        string reverseSecond = "";

        for (int i = first.Length-1; i >= 0; i--)
            reverseFirst += first[i];
        for (int i = second.Length - 1; i >= 0; i--)
            reverseSecond += second[i];

        Console.Write("\n3#\nПолученные строки: " + reverseFirst);
        Console.Write(reverseSecond);

        Console.ReadKey();
    }
}