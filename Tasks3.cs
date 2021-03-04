using System;
using System.Linq;
using System.Text;

namespace TestSpace
{
    class Program
    {
        static void Main()
        {
            int[] array = new int[] { 2, 55, 8, -999, 2, 7, 6, 1, 0, 5, 5, 0, 3, 5, 4, 8, 260, 703 };

            // 1.   Посчитать среднее арифметическое всех элементов массива array
            Console.WriteLine("\n1. Среднее арифметическое массива: " + (double)array.Sum()/array.Length);

            // 2.   Найти сумму всех четных положительных элементов массива array
            var positiveEvenNumbers = array.Where(number => number > 0 && number % 2 == 0);

            Console.WriteLine("\n2. Сумма четных положительных чисел в массиве: " + positiveEvenNumbers.Sum());

            // 3.   Найти результат деления суммы положительных элементов на сумму отрицательных. Результат должен быть дробным числом (не целым).
            int positiveNumbers = array.Where(number => number > 0).Sum();
            int negativeNumbers = array.Where(number => number < 0).Sum();

            Console.WriteLine("\n3. Результат деления суммы положительных чисел на сумму отрицательных: " + (double)positiveNumbers/ negativeNumbers);

            // 4.   Отсортировать элементы массива array по возрастанию
            Array.Sort(array);

            Console.WriteLine("\n4. Отсортированный массив: ");
            foreach (var number in array)
                Console.Write(number + " ");
            Console.WriteLine();

            // 5.   Преобразовать массив array в строку, состояющую из элементов массива, идущих в таком же порядке как и в массиве.
            //      Между элементами массива вставить разделитель (пробел или ,)
            StringBuilder stringifiedArrayBuilder = new StringBuilder();

            foreach (var number in array)
                stringifiedArrayBuilder.Append(number + " ");

            string stringifiedArray = stringifiedArrayBuilder.ToString();
            Console.WriteLine("\n5. Массив преобразованный в строку: " + stringifiedArray);

            // 6.   Зеркально отразить строку, полученную в #5
            StringBuilder reversedStringifiedArrayBuilder = new StringBuilder();

            for (int i = stringifiedArray.Length - 1; i >= 0; i--)
                reversedStringifiedArrayBuilder.Append(stringifiedArray[i]);

            string reversedStringifiedArray = reversedStringifiedArrayBuilder.ToString();
            Console.WriteLine("\n6. Отражение строки:" + reversedStringifiedArray);

            // 7.   Удалить из полученной строки знаки минуса там, где они не имеют математического смысла (после числа и перед разделителем)
            string fixedString = reversedStringifiedArray.Replace("- ", " ");
            if (fixedString.LastIndexOf('-') == fixedString.Length - 1)
                fixedString = fixedString.TrimEnd('-');

            Console.WriteLine("\n7. Очищенная строка:" + fixedString);

            // 8.   Преобразовать строку, полученную в #7 обратно в массив целочисленных значений и записать его в переменную array
            fixedString = fixedString.TrimStart(' ');
            var arrayOfStrings = fixedString.Split(' ');

            array = Array.ConvertAll(arrayOfStrings, int.Parse);

            Console.WriteLine("\n8. Восстановленный массив: ");
            foreach (var number in array)
                Console.Write(number + " ");
            Console.WriteLine();

            // 9.   Создать массив byte[] и заполнить его такими же значениями как и массив array, если число слишком велико для типа byte - заменить его на значение по умолчанию для типа byte
            byte[] bytes = array.Select(i => (byte)i).ToArray();

            Console.WriteLine("\n9. Массив сконвертированный в byte[], переполненные значения заменены на 0: ");
            for(int i = 0; i < bytes.Length; i++)
            {
                if (bytes[i] != array[i])
                    bytes[i] = 0;
                Console.Write(bytes[i] + " ");
            }

            Console.ReadKey();
        }
    }
}