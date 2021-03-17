using System;
using System.Collections.Generic;

namespace Lection7
{
    class Program
    {       
        static void Main(string[] args)
        {
            /* 7.2
             * ♦ Наблюдатель
             *	• Объявить List с произвольным количеством скелетов
             *	• Подписаться классом Наблюдатель на события всех скелетов из списка
             *	• Вызвать метод Kill у всех скелетов*/
            Console.WriteLine("7.2");

            List<Skeleton> skeletons = new List<Skeleton>();

            for (int i = 0; i < 10; i++)
                skeletons.Add(new Skeleton());

            foreach (Skeleton skeleton in skeletons)
                skeleton.OnDeath += Observer.AddListener;

            foreach (Skeleton skeleton in skeletons)
                skeleton.Kill();

            /*7.3
             * Создать объект application класса Application
             * Создать объект admin класса Admin
             * Создать произвольное количество объектов класса User и подписаться ими на обновления приложения методом ListenUpdates
             * Создать новое обновление приложения c помощью метода CreateUpdate*/
            Console.WriteLine("\n7.3");

            Application application = new Application();
            Admin admin = new Admin();
            List<User> users = new List<User>();

            for (int i = 0; i < 10; i++)
                users.Add(new User());

            foreach (User user in users)
                user.ListenUpdates(application);

            application.CreateUpdate(admin.AccountType, "Update 0.1", "Added new bugs");
        }
    }
}
