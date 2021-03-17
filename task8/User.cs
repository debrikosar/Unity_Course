using System;
using System.Collections.Generic;
using System.Text;

/* Объявить тип User содержащий:
 *  • Имя пользователя
 *  • Возраст
 *  • Почтовый адрес
 *  • Конструктор с параметрами*/

namespace Lection8
{
    class User
    {
        private string userName;
        private int userAge;
        private string userEmail;

        public User(string userName, int userAge, string userEmail)
        {
            UserName = userName;
            UserAge = userAge;
            UserEmail = userEmail;
        }

        public string UserName
        {
            get => userName;
            set => userName = value;
        }

        public int UserAge
        {
            get => userAge;
            set => userAge = value;
        }

        public string UserEmail
        {
            get => userEmail;
            set => userEmail = value;
        }
    }
}
