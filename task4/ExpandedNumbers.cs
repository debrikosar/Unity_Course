using System;
using System.Collections.Generic;
using System.Text;

/*6.Написать методы расширения для типов int, float, long.
	Методы должны возвращать строку формата XXXZ, где XXX это первые 3 (если их 3 или больше) цифры числа, а Z - сокращенное обозначение степени.
	Z для различных степеней:
	• K для тысяч
	• M для миллионов
	• B для миллиардов
	• T для триллионов
	Для отсальных степеней выводить просто 3 первых цифры
	
	Примеры:
	для числа 1_000_380 метод должен возвратить 1M
	для числа 1024 метод должен возвратить 1,02K
	для числа 23,84 метод должен возвратить число 23,8*/

namespace Lection4
{
    static class ExpandedNumbers
    {
        public static string ReformatNumber(this long number)
        {
			int n = (int)Math.Log10(number);
			double convertedNumber;
			string stringifiedConvertedNumber;

			char powerSymbol;
			int power;


			if (n < 3)
            {
				powerSymbol = ' ';
				power = 0;
			}
			else if (n < 6)
            {
				powerSymbol = 'K';
				power = 3;
			}
			else if (n < 9)
            {
				powerSymbol = 'M';
				power = 6;
			}
			else if (n < 12)
            {
				powerSymbol = 'B';
				power = 9;
			}
			else if (n < 15)
            {
				powerSymbol = 'T';
				power = 12;
			}
            else
            {
				powerSymbol = '?';
				power = 0;
			}

			convertedNumber = number / Math.Pow(10, power);
			if(convertedNumber.ToString().Contains('.'))
				stringifiedConvertedNumber = convertedNumber.ToString().CutString(4) + powerSymbol;
			else
				stringifiedConvertedNumber = convertedNumber.ToString().CutString(3) + powerSymbol;

			return stringifiedConvertedNumber;
        }

		public static string ReformatNumber(this int number)
		{
			int n = (int)Math.Log10(number);
			double convertedNumber;
			string stringifiedConvertedNumber;

			char powerSymbol;
			int power;


			if (n < 3)
			{
				powerSymbol = ' ';
				power = 0;
			}
			else if (n < 6)
			{
				powerSymbol = 'K';
				power = 3;
			}
			else if (n < 9)
			{
				powerSymbol = 'M';
				power = 6;
			}
			else if (n < 12)
			{
				powerSymbol = 'B';
				power = 9;
			}
			else if (n < 15)
			{
				powerSymbol = 'T';
				power = 12;
			}
			else
			{
				powerSymbol = '?';
				power = 0;
			}

			convertedNumber = number / Math.Pow(10, power);
			if (convertedNumber.ToString().Contains('.'))
				stringifiedConvertedNumber = convertedNumber.ToString().CutString(4) + powerSymbol;
			else
				stringifiedConvertedNumber = convertedNumber.ToString().CutString(3) + powerSymbol;

			return stringifiedConvertedNumber;
		}

		public static string ReformatNumber(this float number)
		{
			int n = (int)Math.Log10(number);
			double convertedNumber;
			string stringifiedConvertedNumber;

			char powerSymbol;
			int power;


			if (n < 3)
			{
				powerSymbol = ' ';
				power = 0;
			}
			else if (n < 6)
			{
				powerSymbol = 'K';
				power = 3;
			}
			else if (n < 9)
			{
				powerSymbol = 'M';
				power = 6;
			}
			else if (n < 12)
			{
				powerSymbol = 'B';
				power = 9;
			}
			else if (n < 15)
			{
				powerSymbol = 'T';
				power = 12;
			}
			else
			{
				powerSymbol = '?';
				power = 0;
			}

			convertedNumber = number / Math.Pow(10, power);
			if (convertedNumber.ToString().Contains('.'))
				stringifiedConvertedNumber = convertedNumber.ToString().CutString(4) + powerSymbol;
			else
				stringifiedConvertedNumber = convertedNumber.ToString().CutString(3) + powerSymbol;

			return stringifiedConvertedNumber;
		}
	}
}
