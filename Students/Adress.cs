using System;
using System.Collections.Generic;
using System.Text;

namespace Students
{
    class Adress
    {
        private string city;
        private string street;
        private int house;

        public Adress(string city, string street, int house)
        {
            this.city = city;
            this.street = street;
            this.house = house;
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        public int House
        {
            get { return house; }
            set { house = value; }
        }
        public string AddresToString()
        {
            return (city + " " + street + " " + house.ToString());
        }
    }
}
