using System;

namespace Lection4
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.
            string testString = "Hello World";

            Console.WriteLine("1.");
            Console.WriteLine(testString.CutString(2));
            Console.WriteLine(testString.GetStringPart(1, 5));
            Console.WriteLine(testString.AddStringsToBaseString(new string[] {"test", "1", "232" }));
            Console.WriteLine(testString.InvertUppercaseLowercase());

            //2.
            int convertableInt = 99999;
            byte[] result = IntToByte(convertableInt);

            Console.WriteLine("\n2.");
            foreach(byte b in result)
            {
                Console.Write("{0} ", b);
            }

            //3.
            Vector3D firstVector = new Vector3D(2, 4, 0);
            Vector3D secondVector = new Vector3D(1, 2, 3);

            Console.WriteLine("\n\n3.");
            Console.WriteLine(Vector3D.VectorSum(firstVector, secondVector).ToString());
            Console.WriteLine(Vector3D.VectorDifference(firstVector, secondVector).ToString());

            //4.
            Console.WriteLine("\n4.");
            Console.WriteLine(ReturnTypeName(convertableInt.GetType()));
            Console.WriteLine(ReturnTypeName(firstVector.GetType()));
            Console.WriteLine(ReturnTypeName(result.GetType()));

            //5.
            Console.WriteLine("\n5.");
            Library testLibrary = new Library();
            Book yetAnotherTestBook = new Book("test");

            testLibrary.AddBook(testString);
            testLibrary.AddBook(new Book("testBook"));
            testLibrary.AddBook(new Book(bookName: "another testBook"));
            testLibrary.AddBook(yetAnotherTestBook);

            testLibrary.ShowBooks();

            testLibrary.RemoveBook(testString);
            testLibrary.RemoveBook(yetAnotherTestBook);

            testLibrary.ShowBooks();

            //6.
            int testInt = 111111;
            long testLong = 11111111111111;
            float testFloat = 11.1f;

            Console.WriteLine("\n6.");
            Console.WriteLine(testInt.ReformatNumber());
            Console.WriteLine(testLong.ReformatNumber());
            Console.WriteLine(testFloat.ReformatNumber());

        }

        //2.  Создать метод, который преобразует целое число в массив байт
        public static byte[] IntToByte(int number)
        {
            return BitConverter.GetBytes(number);
        }

        //4. 	Создать метод, принимающий любой тип и возвращающий название этого типа в виде строки
        public static string ReturnTypeName(Type anyType)
        {
            return anyType.ToString();
        }
    }
}
