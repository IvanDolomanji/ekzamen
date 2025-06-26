using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Invoice
    {
        private readonly int account;
        private readonly string customer;
        private readonly string provider;
        private string article;
        private int quantity;

        // Конструктор для инициализации неизменяемых полей
        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

        // Свойство для получения номера счета
        public int Account
        {
            get { return account; }
        }

        // Свойство для получения имени клиента
        public string Customer
        {
            get { return customer; }
        }

        // Свойство для получения имени поставщика
        public string Provider
        {
            get { return provider; }
        }

        // Метод для установки статьи и количества
        public void SetArticleAndQuantity(string article, int quantity)
        {
            this.article = article;
            this.quantity = quantity;
        }

        // Метод для получения названия товара
        public string GetArticle()
        {
            return article;
        }

        // Метод для получения количества
        public int GetQuantity()
        {
            return quantity;
        }

        // Метод для вычисления стоимости без НДС
        public double CalculateCostWithoutVat()
        {
            // Предполагаем базовую цену за единицу товара (например, 10 BYN)
            double basePrice = 10.0;
            return quantity * basePrice;
        }

        // Метод для вычисления стоимости с НДС (20%)
        public double CalculateCostWithVat()
        {
            double costWithoutVat = CalculateCostWithoutVat();
            double vatRate = 0.20; // НДС 20%
            return costWithoutVat * (1 + vatRate);
        }
    }
}
