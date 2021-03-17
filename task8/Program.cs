using System;
using System.Collections.Generic;
using System.Linq;

namespace Lection8
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 8.1
             * Создать коллекцию из 5 пользователей
             *      [Использовать LINQ]
             * Создать List<User>, в который добавить только пользователей старше 13 лет и почтовые ящики у которых содержат символ @*/
            Console.WriteLine("8.1");

            List<User> unsortedUsers = new List<User>();
            unsortedUsers.Add(new User("Bob", 12, "bob@gmail.com"));
            unsortedUsers.Add(new User("Tim", 19, "tim.com"));
            unsortedUsers.Add(new User("John", 10, "john"));
            unsortedUsers.Add(new User("Jim", 35, "jim@gmail.com"));
            unsortedUsers.Add(new User("Jacke", 40, "jacke@gmail.com"));

            List<User> sortedUser = unsortedUsers.Where(user => user.UserAge > 13 && user.UserEmail.Contains('@')).ToList();
            foreach (User user in sortedUser)
                Console.WriteLine(user.UserName);

            /* 8.2
             * [Использовать LINQ]
             * 
             * Необходимо получить список уникальных (без повторений) доменных имен почтовых ящиков из списка почтовых адресов
             * Доменное имя - правая часть почтового адреса (всё что после @)*/

            string[] emails = new string[]
            {
            "randommail@mail.ru",
            "someoneshere@gmail.by",
            "jackteller@gmail.com",
            "yellow.brick.records@mail.cz",
            "randommail2@mail.ru",
            "kidywalters999@gmail.com",
            "mail.trueman@mail.cz",
            "sol.goodman@gmail.com",
            "alfick.demon.44@mail.gv.cz"
            };

            List<string> domenNames = emails.Where(email => email.Contains('@'))
                .Select(email => email.Substring(email.IndexOf("@")))
                .Distinct()
                .ToList();
  
            Console.WriteLine("8.2");
            foreach (string domen in domenNames)
                Console.WriteLine(domen);

            /*8.3
             * Main
             *  • Создать игроков (с произвольными никнеймами, уровнем и расой)
             *  • Создать базу данных
             *  • Добавить игроков в базу данных
             *  [LINQ]
             *  Сформировать из игроков, находящихся в базе данных, следующие выборки:
             *  • Игроки одной расы (любая произвольная раса из существующих)
             *  • Игроки больше X уровня. X выбрать произвольно.
             *  • Игроки, чьи ники начинаются с определенной (произвольной) буквы
             *  • Игроки расы X с уровнем не больше чем A и игроки расы Y с уровнем не больше чем B. A, B, X, Y выбрать на свое усмотрение.
            */

            DateBase dateBase = new DateBase(7);

            Race humanRace = new Race("human");
            Race gnomeRace = new Race("gnome");
            Race lizardRace = new Race("lizard");

            Player firstPlayer = new Player("Ben", 11, humanRace);
            Player secondPlayer = new Player("Jack", 12, gnomeRace);
            Player thirdPlayer = new Player("Jill", 4, humanRace);
            Player fourthPlayer = new Player("Lynda", 90, lizardRace);
            Player fifthPlayer = new Player("Tom", 50, gnomeRace);
            Player sixthPlayer = new Player("Ben", 11, humanRace);
            Player seventhPlayer = new Player("Alex", 20, lizardRace);
            Player eighthPlayer = new Player("Mary", 12, gnomeRace);
            Player ninthPlayer = new Player("Maxine", 13, humanRace);

            dateBase.AddPlayer(firstPlayer, secondPlayer, thirdPlayer, fourthPlayer, fifthPlayer, sixthPlayer, seventhPlayer, eighthPlayer, ninthPlayer);

            var lizardPlayers = dateBase.Players.Where(player => player.PlayerRace.Name == lizardRace.Name);
            var playersOver20Level = dateBase.Players.Where(player => player.PlayerAge > 20);
            var playersWithJasFirstLetter = dateBase.Players.Where(player => player.PlayerName[0] == 'J');
            var playersWithRaceAndLevelCombo = dateBase.Players
                .Where(player => player.PlayerRace.Name == humanRace.Name && player.PlayerAge > 10)
                .Union(dateBase.Players.Where(player => player.PlayerRace.Name == gnomeRace.Name && player.PlayerAge > 10));

            Console.WriteLine("8.3\n1.");
            foreach (Player player in lizardPlayers)
                player.Display();

            Console.WriteLine("2.");
            foreach (Player player in playersOver20Level)
                player.Display();

            Console.WriteLine("3.");
            foreach (Player player in playersWithJasFirstLetter)
                player.Display();

            Console.WriteLine("4.");
            foreach (Player player in playersWithRaceAndLevelCombo)
                player.Display();

        }
    }
}
