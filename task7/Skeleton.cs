using System;
using System.Collections.Generic;
using System.Text;

namespace Lection7
{
    /*Создать класс Скелет
     *  • Создать статическое целочисленное поле lastID
     *  • Создать поле id
     *  • Создать событие OnDeath, реализовать через делегат Action<int>
     *  • Создать конструктор по умолчанию, которые присваивает полю id уникальное значение (в качестве счетчика использовать статическое поле lastID)
     *  • Создать метод Kill, который убивает скелета и вызывает событие OnDeath (в качесиве параметра передавать id скелета)*/

    class Skeleton
    {
        public static int lastID;
        public int id;

        public delegate void Action();
        public event Action<int> OnDeath;

        public Skeleton()
        {
            id = lastID;
            lastID++;
        }

        public void Kill() => OnDeath?.Invoke(id);        
    }

    /*Создать статический класс Наблюдатель
     *  • Создать в нём статический метод void AddListener(int) который выводит принимаемое число*/   

    static class Observer
    {
        public static void AddListener(int id) => Console.WriteLine(id);
    }
}
