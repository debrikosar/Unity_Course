using System;
using System.Collections.Generic;
using System.Text;

namespace Lection7
{
    /*  Создать класс Application со следующими полями и методами:
 *      • Открытый делегат с сигнатурой void MessageDelegate(string, string)
 *      • Открытый событие event MessageDelegate OnUpdateRelease
 *      • Открытый метод CreateUpdate(AccountType accountType, string updateName, string updateDescription)
 *      в котором при условии, что accountType соответствует администратору, вызывать событие (с передачей в него updateName и updateDescription)*/
    class Application
    {
        public delegate void MessageDelegate(string updateName, string updateDescription);

        public event MessageDelegate OnUpdateRelease;

        public void CreateUpdate(AccountType accountType, string updateName, string updateDescription)
        {
            if (accountType == AccountType.Admin)
                OnUpdateRelease(updateName, updateDescription);
        }
    }

    //  Создать перечисление AccountType с двумя полями Admin и User

    enum AccountType
    {
        Admin,
        User
    }

    /*  Создать абстрактный класс AbstractUser и объявить в нем:
*      • Защищенным поле accountType типа AccountType
*      • Публичное свойство AccountType типа AccountType, обеспечив через него достук к полю accountType только для чтения*/

    abstract class AbstractUser
    {
        protected AccountType accountType;

        public AccountType AccountType
        {
            get => accountType;
        }
    }

    /*Создать класс User и наследовать его от AbstractUser
 *      • Конструктор по умолчанию, инициализирующий поле accountType значением AccountType.User
 *      • Закрытый метод с сигнатурой void ShowMessage(string, string), который выводит информацию об обновлении (название обновления и его описание)
 *      • Метод ListenUpdates, который принимает в качестве параметра объект типа Application*/

    class User : AbstractUser
    {
        public User()
        {
            accountType = AccountType.User;
        }

        private void ShowMessage(string updateName, string updateDescription) =>
            Console.WriteLine($"{updateName}\n{updateDescription}");
        
        public void ListenUpdates(Application application)
        {
            application.OnUpdateRelease += ShowMessage;
        }
    }

    /*  Создать класс Admin и наследовать его от AbstractUser
 *      • Создать конструктор по умолчанию, инициализирующий поле accountType значением AccountType.Admin*/

    class Admin : AbstractUser
    {
        public Admin()
        {
            accountType = AccountType.Admin;
        }
    }
}
