using System;
using System.Collections.Generic;
using System.Text;

/* 1.
 * ♦ Создать класс для математических операций ♦
 * Класс должен содержать следующие методы:
 * • Перегруженный метод Sum, которые возвращает сумму переданных в него параметров одного типа (int или float)
 * • Перегруженный метод Div, принимающий два параметра (int или float) и возвращающий результат деления первого на второе
 * [Дополнительно] Определить другие математические операции
 */

namespace Lection5
{
    class MathOperations
    {
        public static int Sum(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
        public static float Sum(float firstNumber, float secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public static int Diff(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }
        public static float Diff(float firstNumber, float secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public static float Multiply(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }
        public static float Multiply(float firstNumber, float secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public static float Div(int firstNumber, int secondNumber)
        {
            return (float) firstNumber / secondNumber;
        }
        public static float Div(float firstNumber, float secondNumber)
        {
            return firstNumber / secondNumber;
        }
    }
}
