using System;

namespace Lection5
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.
            int firstInt = 10;
            int secondInt = 2;

            float firstFloat = 1.2f;
            float secondFloat = 0.5f;

            Console.WriteLine("1.");
            Console.WriteLine(MathOperations.Sum(firstInt, secondInt));
            Console.WriteLine(MathOperations.Sum(firstFloat, secondFloat));
            Console.WriteLine(MathOperations.Diff(firstInt, secondInt));
            Console.WriteLine(MathOperations.Diff(firstFloat, secondFloat));
            Console.WriteLine(MathOperations.Multiply(firstInt, secondInt));
            Console.WriteLine(MathOperations.Multiply(firstFloat, secondFloat));
            Console.WriteLine(MathOperations.Div(firstInt, secondInt));
            Console.WriteLine(MathOperations.Div(firstFloat, secondFloat));

            //2.
            Hat firstHat = new Hat();
            Hat secondHat = new Hat("Forgotten Helmet of Good Memory", 10);
            Boots firstBoots = new Boots();
            Boots secondBoots = new Boots("Burning Ice Plate Boots of Dashing Slowness", 5);
            Gloves firstGloves = new Gloves();
            Gloves secondGloves = new Gloves("Electrically Charged Gauntlets of Electricity Resistance", 7);
            BodyArmor firstArmor = new BodyArmor();
            BodyArmor secondArmor = new BodyArmor("Heavy Armor of Feather Drop", 35);

            IEquipped equipManager;

            Console.WriteLine("\n2.");
            equipManager = firstHat;
            equipManager.ShowDescrition();
            equipManager = secondHat;
            equipManager.ShowDescrition();
            equipManager = firstBoots;
            equipManager.ShowDescrition();
            equipManager = secondBoots;
            equipManager.ShowDescrition();
            equipManager = firstGloves;
            equipManager.ShowDescrition();
            equipManager = secondGloves;
            equipManager.ShowDescrition();
            equipManager = firstArmor;
            equipManager.ShowDescrition();
            equipManager = secondArmor;
            equipManager.ShowDescrition();

            /*3.
            Создать по одному объекту класса Скелет и Волк.
            Параметры, передаваемые в констуктор при создании объектов, должны генерироваться случайно при каждом запуске (использовать класс Random)
            Имитировать в коде битву между волком и скелетом до тех пор, пока у одного из них здоровье не будет меньше или равно 0
            Выводить в консоль начальные параметры монстров и лог ведения боя*/

            Random random = new Random();
            Skeleton skeleton = new Skeleton("Eldritch Skeleton", random.Next(10, 100), random.Next(1, 10), random.Next(1, 10));
            Wolf wolf = new Wolf("Winter Wolf", random.Next(10, 100), random.Next(1, 10), random.Next(1, 5));

            Console.WriteLine("\n3.");
            Console.WriteLine(skeleton.ToString());
            Console.WriteLine(wolf.ToString());

            while(wolf.HealthPoint > 0 && skeleton.HealthPoint > 0)
            {
                Console.WriteLine("\n");
                skeleton.GetDamage(wolf.Hit());
                wolf.GetDamage(skeleton.Hit());
            }
            Console.WriteLine("\n");
            skeleton.CheckIfDead();
            wolf.CheckIfDead();
        }
    }
}
