using System;
using System.Collections.Generic;
using System.Text;

/*2.
 *♦ Создать интерфейс, позволяющий выводить описание одежды вне зависимости от её типа ♦
 *
 *Для этого необходимо создать:
 *  • Перечисление EquipType, содержащее тип одежды (торс, ноги, руки, голова)
 *  • Создать интерфейс IEquipped свойство типа EquipType и метод ShowDescription
 *  • Создать 2 любых класса для одежды (например, Hat и Boots) и реализовать в них интерфейс IEquipped
 *  • [По желанию] добавить индивидуальные поля или методы для классов одежды
 *  • Создать объекты классов одежды
 *  • Создать переменную тип IEquipped и с её помощью вывести на консоль описание всей созданной одежды на экран с помощью метода ShowDescription()*/

namespace Lection5
{
    interface IEquipped
    {
        EquipType EquipSlot{ get; set; }

        void ShowDescrition();
    }

    enum EquipType
    {
        Torso,
        Legs,
        Arms,
        Head
    }

    class Hat : IEquipped
    {
        private string equipName;

        private EquipType equipSlot;

        private int armorPoints;

        public Hat() : this("Unidentified hat", 0)
        {

        }

        public Hat(string equipName, int armorPoints)
        {
            EquipName = equipName;
            EquipSlot = EquipType.Head;
            ArmorPoints = armorPoints;
        }

        public string EquipName
        {
            get
            {
                return equipName;
            }
            set
            {
                equipName = value;
            }
        }

        public EquipType EquipSlot 
        { 
            get 
            {
                return equipSlot;
            }
            set 
            {
                if (value == EquipType.Head)
                    equipSlot = value;
                else
                    Console.WriteLine("You can only wear hats on your head");
            }
        }
        public int ArmorPoints
        {
            get
            {
                return armorPoints;
            }
            set
            {
                armorPoints = value;
            }
        }

        public void ShowDescrition()
        {
            Console.WriteLine($"It's a {equipName} which gives +{armorPoints}AP " +
                $"when equipped. It belongs to a {equipSlot} slot");
        }
    }

    class Boots : IEquipped
    {
        private string equipName;

        private EquipType equipSlot;

        private int armorPoints;

        public Boots() : this("Unidentified boots", 0)
        {

        }

        public Boots(string equipName, int armorPoints)
        {
            EquipName = equipName;
            EquipSlot = EquipType.Legs;
            ArmorPoints = armorPoints;
        }

        public string EquipName
        {
            get
            {
                return equipName;
            }
            set
            {
                equipName = value;
            }
        }

        public EquipType EquipSlot
        {
            get
            {
                return equipSlot;
            }
            set
            {
                if (value == EquipType.Legs)
                    equipSlot = value;
                else
                    Console.WriteLine("You can only wear boots on your legs");
            }
        }
        public int ArmorPoints
        {
            get
            {
                return armorPoints;
            }
            set
            {
                armorPoints = value;
            }
        }

        public void ShowDescrition()
        {
            Console.WriteLine($"It's a {equipName} which gives +{armorPoints}AP " +
                $"when equipped. It belongs to a {equipSlot} slot");
        }
    }

    class Gloves : IEquipped
    {
        private string equipName;

        private EquipType equipSlot;

        private int armorPoints;

        public Gloves() : this("Unidentified gloves", 0)
        {

        }

        public Gloves(string equipName, int armorPoints)
        {
            EquipName = equipName;
            EquipSlot = EquipType.Arms;
            ArmorPoints = armorPoints;
        }

        public string EquipName
        {
            get
            {
                return equipName;
            }
            set
            {
                equipName = value;
            }
        }

        public EquipType EquipSlot
        {
            get
            {
                return equipSlot;
            }
            set
            {
                if (value == EquipType.Arms)
                    equipSlot = value;
                else
                    Console.WriteLine("You can only wear gloves on your arms");
            }
        }
        public int ArmorPoints
        {
            get
            {
                return armorPoints;
            }
            set
            {
                armorPoints = value;
            }
        }

        public void ShowDescrition()
        {
            Console.WriteLine($"It's a {equipName} which gives +{armorPoints}AP " +
                $"when equipped. It belongs to a {equipSlot} slot");
        }
    }

    class BodyArmor : IEquipped
    {
        private string equipName;

        private EquipType equipSlot;

        private int armorPoints;

        public BodyArmor() : this("Unidentified gloves", 0)
        {

        }

        public BodyArmor(string equipName, int armorPoints)
        {
            EquipName = equipName;
            EquipSlot = EquipType.Torso;
            ArmorPoints = armorPoints;
        }

        public string EquipName
        {
            get
            {
                return equipName;
            }
            set
            {
                equipName = value;
            }
        }

        public EquipType EquipSlot
        {
            get
            {
                return equipSlot;
            }
            set
            {
                if (value == EquipType.Torso)
                    equipSlot = value;
                else
                    Console.WriteLine("You can only wear armor on your torso");
            }
        }
        public int ArmorPoints
        {
            get
            {
                return armorPoints;
            }
            set
            {
                armorPoints = value;
            }
        }

        public void ShowDescrition()
        {
            Console.WriteLine($"It's a {equipName} which gives +{armorPoints}AP " +
                $"when equipped. It belongs to a {equipSlot} slot");
        }
    }
}
