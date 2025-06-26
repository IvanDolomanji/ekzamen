using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Employee
    {
        private string lastName;
        private string firstName;

        // Конструктор для инициализации фамилии и имени
        public Employee(string lastName, string firstName)
        {
            this.lastName = lastName;
            this.firstName = firstName;
        }

        // Свойство для получения фамилии
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        // Свойство для получения имени
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        // Метод для получения названия должности
        public string GetPositionName(string positionInput)
        {
            switch (positionInput)
            {
                case "1":
                    return "Junior";
                case "2":
                    return "Middle";
                case "3":
                    return "Senior";
                default:
                    return "Неизвестная должность";
            }
        }

        // Метод для вычисления оклада и налогового сбора
        public (double salary, double tax) CalculateSalaryAndTax(string positionInput, double experience)
        {
            double baseSalary;

            // Определяем базовый оклад в зависимости от должности
            switch (positionInput)
            {
                case "1": // Junior
                    baseSalary = 1000;
                    break;
                case "2": // Middle
                    baseSalary = 2000;
                    break;
                case "3": // Senior
                    baseSalary = 3000;
                    break;
                default:
                    baseSalary = 500; // На случай некорректного ввода
                    break;
            }

            // Увеличиваем оклад на 10% за каждый год стажа
            double salary = baseSalary * (1 + 0.1 * experience);

            // Налоговый сбор 13% от оклада
            double tax = salary * 0.13;

            return (salary, tax);
        }
    }
}
