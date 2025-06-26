using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class User
    {
        private string login;
        private string firstName;
        private string lastName;
        private int age;
        private readonly DateTime registrationDate;

        // Конструктор для инициализации полей
        public User(string login, string firstName, string lastName, int age)
        {
            this.login = login;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.registrationDate = DateTime.Now; // Устанавливаем текущую дату и время
        }

        // Свойство для логина
        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        // Свойство для имени
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        // Свойство для фамилии
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        // Свойство для возраста
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        // Свойство для даты заполнения анкеты (только чтение)
        public DateTime RegistrationDate
        {
            get { return registrationDate; }
        }
    }
}
