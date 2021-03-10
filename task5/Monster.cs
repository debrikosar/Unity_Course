using System;
using System.Collections.Generic;
using System.Text;

namespace Lection5
{

/*Создать абстрактный класс Монстр, содержащий общие для существ поля и методы
 *  Свойства:
 *      • Очки жизни (хп)
 *      • Урон
 *      • Доп. переменные по желанию
 *  Методы:
 *  • GetDamage (получения урона)
 *  • Hit (нанесение урона)*/

    abstract class Monster
    {
        private string monsterName;
        private int healthPoint;
        private int damage;

        public Monster(string monsterName, int healthPoint, int damage)
        {
            MonsterName = monsterName;
            HealthPoint = healthPoint;
            Damage = damage;
        }
        
        public string MonsterName
        {
            get
            {
                return monsterName;
            }

            set
            {
                monsterName = value;
            }
        }

        public int HealthPoint
        {
            get
            {
                return healthPoint;
            }

            set
            {
                healthPoint = value;
            }
        }

        public int Damage
        {
            get
            {
                return damage;
            }

            set
            {
                damage = value;
            }
        }

        public virtual void GetDamage(int incomingDamage)
        {
            if (HealthPoint > 0)
            {
                HealthPoint -= incomingDamage;
                Console.WriteLine($"{MonsterName} got {incomingDamage} damage");
            }
            else
                Console.WriteLine($"{monsterName} is dead");
        }

        public virtual int Hit()
        {
            Console.WriteLine($"{MonsterName} deals {Damage} damage");
            return damage;
        }

        public void CheckIfDead()
        {
            if (HealthPoint <= 0)
                Console.WriteLine($"{MonsterName} is dead");
        }

    }

/*Создать структуру Броня, содержащую:
 *  • Свойство или поле типа int (описывает величину урона, который будет блокироваться при каждом ударе)
 *  • Конструктор, позволяющий инициализировать это свойство*/

    struct Armor
    {
        private int damageBlock;

        public Armor(int damageBlock)
        {
            this.damageBlock = damageBlock;
        }

        public int DamageBlock
        {
            get
            {
                return damageBlock;
            }

            set
            {
                damageBlock = value;
            }
        }

    }

/*Создать класс Скелет, наследуемый от класса Монстр
 *  В классе определить:
 *      • Закрытое поле типа Armor
 *      • Конструктор, позволяющий инициализировать поля объекта типа Скелет (в том числе, позволяющий задать величину урона, блокируемого броней)
 *      • Переопределить метод получения урона так, чтобы учитывался показатель экипированной брони*/

    class Skeleton : Monster
    {
        private Armor equipedArmor;

        public Skeleton(string skeletonName, int health, int damage, int damageBlock) : base(skeletonName, health, damage)
        {
            equipedArmor = new Armor(damageBlock);
        }

        public override void GetDamage(int incomingDamage)
        {
            if (HealthPoint > 0 && incomingDamage > equipedArmor.DamageBlock)
            {
                HealthPoint -= incomingDamage - equipedArmor.DamageBlock;
                Console.WriteLine($"{MonsterName} got {incomingDamage - equipedArmor.DamageBlock} damage");
            }
            else if (HealthPoint <= 0)
                Console.WriteLine($"{MonsterName} is dead");
            else
                Console.WriteLine($"{MonsterName} got 0 damage");
        
        }

        public override string ToString()
        {
            return $"{MonsterName} has {HealthPoint}HP, can deal {Damage} base damage and has {equipedArmor.DamageBlock} armor points";
        }
    }

/*Создать класс Волк, наследуемый от класса Монстр:
 *  • Закрытое свойство, определяющее количество зубов у Волка (ограничить диапазон принимаемых значение от 0 до 100)
 *  • Конструктор, позволяющий инициализировать поля объекта типа Волк (в том числе, позволяющий задать количество зубов)
 *  • Переопределить метод нанесения урона так, чтобы учитывалось количество зубов*/

    class Wolf : Monster
    {
        private int teethAmount;

        public Wolf(string wolfName, int health, int damage, int teethAmount) : base(wolfName, health, damage)
        {
            TeethAmount = teethAmount;
        }

        private int TeethAmount
        {
            get
            {
                return teethAmount;
            }

            set
            {
                if (value > 0 && value <= 100)
                    teethAmount = value;
                else
                    teethAmount = 1;
            }
        }

        public override int Hit()
        {
            Console.WriteLine($"{MonsterName} deals {Damage * TeethAmount} damage");
            return Damage * TeethAmount;
        }

        public bool IsCircusPerformer()
        {
            return false;
        }

        public override string ToString()
        {
            return $"{MonsterName} has {HealthPoint}HP, can deal {Damage} base damage per tooth and has {teethAmount} teeth";
        }
    }

}
