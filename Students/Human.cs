using System;
using System.Collections.Generic;
using System.Text;

namespace Students
{
    class Human
    {
        protected string name;
        protected string surname;
        protected int age;
        protected Adress adres;

        public Human(string name, string surname, int age, Adress adres)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.adres = adres;
        }
        public string GetInfo()
        {
            return ($"Name:{name}\nAge:{age}\n");
        }
        public Adress Adress { get { return adres; } set { adres = value; } }
        public String Name { get { return name; } set { name = value; } }
        public String Surname { get { return surname; } set { surname = value; } }
        public int Age { get { return age; } set { age = value; } }
    }
}
