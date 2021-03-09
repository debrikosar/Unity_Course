using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*1.  Создать класс с методами расширения для типа String
	Класс должен уметь:
		• Обрезать входную строку до индекса, заданного пользователем
		• Возвращать часть строки, в качестве параметров начальный индекс и конечный
		• Присоединять к строке произвольное количество других строк
		• Заменять все буквы на заглавные и наоборот*/

namespace Lection4
{

	static class ExpandedString
	{
		public static string CutString(this string baseString, int end)
		{
			return baseString.Substring(0, end);
		}

		public static string GetStringPart(this string baseString, int start, int end)
		{
			return baseString.Substring(start, end);
		}

		public static string AddStringsToBaseString(this string baseString, string[] strings)
        	{
			return baseString + string.Concat(strings);
		}

		public static string InvertUppercaseLowercase(this string baseString)
        	{
			string reverseString = new string(baseString.Select(symbol => char.IsLetter(symbol) ?
			(char.IsUpper(symbol) ? char.ToLower(symbol) : char.ToUpper(symbol)) : symbol).ToArray());
			return reverseString;
		}
	}
}
