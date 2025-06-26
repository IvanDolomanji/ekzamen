using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Address
    {
        private string index;
        private string country;
        private string city;
        private string street;
        private string house;
        private string apartment;

        // Свойство для почтового индекса с методами get и set
        public string Index
        {
            get { return index; }
            set { index = value; }
        }

        // Свойство для страны с методами get и set
        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        // Свойство для города с методами get и set
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        // Свойство для улицы с методами get и set
        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        // Свойство для номера дома с методами get и set
        public string House
        {
            get { return house; }
            set { house = value; }
        }

        // Свойство для номера квартиры с методами get и set
        public string Apartment
        {
            get { return apartment; }
            set { apartment = value; }
        }
    }
}
