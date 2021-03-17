using System;
using System.Collections.Generic;
using System.Text;

namespace Lection8
{
    /*Создать структуру Race
     *  • Свойство Name (только для чтения)
     *  • Конструктор, инициализирующий Name*/

    struct Race
    {
        private string name;

        public Race(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get => name;
        }
    }

    /*Создать класс Player, содержащий:
     *[Информация] Модификаторы доступа и сигнатуру (поле или свойство) выбрать на свое усмотрение
     *  • Ник
     *  • Возраст персонажа
     *  • Раса (тип Race)
     *  • Конструктор для инициализации полей*/

    class Player
    {
        private string playerName;
        private int playerAge;
        private Race playerRace;

        public Player(string playerName, int playerAge, Race playerRace)
        {
            PlayerName = playerName;
            PlayerAge = playerAge;
            PlayerRace = playerRace;
        }

        public string PlayerName
        {
            get => playerName;
            set => playerName = value;
        }

        public int PlayerAge
        {
            get => playerAge;
            set => playerAge = value;
        }

        public Race PlayerRace
        {
            get => playerRace;
            set => playerRace = value;
        }

        public void Display() =>
            Console.WriteLine($"Player name: {playerName}, player lvl: {playerAge}, player race: {playerRace.Name}");
    }

    /*Создать класс DataBase
     *[Информация] Модификаторы доступа и сигнатуру (поле или свойство) выбрать на свое усмотрение
     *  • Максимальный размер базы данных (целое число)
     *  • Коллекция для хранения объектов типа Player
     *  • Конструктор, инициализирующий максимальный размер базы данных
     *  • Открытый метод void AddPlayers(X) для добавления игроков. Вместо X — возможность принимать в качестве параметра любое количество объектов типа Player.
     *      • Учесть в базе данных возможность нехватки места (превышение макс. размера базы)
     *      • Учесть возможность наличия такого никнейма в базе до его добавления (реализовать с использованием следующего метода)
     *      • Закрытый метод bool IsNickNameExists(string nickname) возвращающий true если такой ник уже есть в базе, false - иначе*/

    class DateBase
    {
        private int databaseSize;
        private List<Player> players = new List<Player>();

        public DateBase(int databaseSize)
        {
            DatabaseSize = databaseSize;
        }

        public int DatabaseSize
        {
            get => databaseSize;
            set => databaseSize = value;
        }

        public List<Player> Players
        {
            get => players;
            set => players = value;
        }

        public void AddPlayer(params Player[] newPlayers)
        {
            foreach (Player player in newPlayers)
                if (players.Count < databaseSize && !IsNickNameExists(player))
                    players.Add(player);
        }

        private bool IsNickNameExists(Player player)
        {
            return players.Exists(existingPlayer => existingPlayer.PlayerName == player.PlayerName);
        }

    }
}
