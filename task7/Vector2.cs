using System;
using System.Collections.Generic;
using System.Text;

/*
 * Создать класс или структуру Vector2
 *  • Объявить поля/свойства для хранения координат X, Y
 *  • Создать конструктор с параметрами
 *  • Перегрузить операторы +, -, ++, --, ==, !=
 *  • Переопределить методы GetHashCode, Equals, ToString
 *  • Создать 2 открытых статических поля, характеризующих нулевой (0, 0) и единичный (0, 1) векторы
*/

namespace Lection7
{
    class Vector2
    {
        private int x;
        private int y;

        public static Vector2 vector00 = new Vector2(0, 0);
        public static Vector2 vector01 = new Vector2(0, 1);

        public int X
        {
            get => x;

            set => x = value;
        }

        public int Y
        {
            get => y;

            set => y = value;
        }

        public Vector2(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static Vector2 operator +(Vector2 firstVector, Vector2 secondVector) => 
            new Vector2(firstVector.X + secondVector.X, firstVector.Y + secondVector.Y);

        public static Vector2 operator -(Vector2 firstVector, Vector2 secondVector) =>
            new Vector2(firstVector.X - secondVector.X, firstVector.Y - secondVector.Y);

        public static Vector2 operator ++(Vector2 vector)
        {
            return new Vector2(vector.X + 1, vector.Y + 1);
        }

        public static Vector2 operator --(Vector2 vector)
        {
            return new Vector2(vector.X - 1, vector.Y - 1);
        }

        public static bool operator ==(Vector2 firstVector, Vector2 secondVector)
        {
            return firstVector.X == secondVector.X && firstVector.Y == secondVector.Y;
        }

        public static bool operator !=(Vector2 firstVector, Vector2 secondVector)
        {
            return firstVector.X != secondVector.X || firstVector.Y != secondVector.Y;
        }

        public override int GetHashCode()
        {
            return X*Y;
        }   

        public override bool Equals(Object vector)
        {
            return this == vector;
        }

        public override string ToString()
        {
            return $"x: {x}, y: {y}";
        }

    }
}
