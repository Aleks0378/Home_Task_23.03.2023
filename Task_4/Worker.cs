using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Задание 4
//Создать абстрактный базовый класс Worker (работника) 
//с методом Print(). Создайте четыре производных класса: 
//President, Security, Manager, Engineer. Переопределите метод
//Print() для вывода информации, соответствующей 
//каждому типу работника.

namespace Task_4
{
    public abstract class Worker
    {
        public string name { get; set; }
        public int age { get; set; }
        public int salary { get; set; }
        public bool maritalStatus { get; set; }

        public Worker(string name,int age, int salary, bool maritalStatus)
        {
            this.name = name;
            this.age = age;
            this.salary = salary;
            this.maritalStatus = maritalStatus;
        }

        public abstract void Print();
    }
    public class President: Worker
    {
        public string country { get; set; }
        public President(string n,int a, int sal, bool mS,string country): base(n,a,sal,mS)
        {
            this.country = country;
        }

        public override void Print()
        {
            Console.WriteLine($"\n\tPresident name: {name}, age: {age} years, country: {country}, salary: {salary} usd, marriage: {(maritalStatus?"Yes":"No")}");
        }
    }
    public class Security : Worker
    {
        public string company { get; set; }
        public Security(string n,int a, int sal, bool mS, string c) : base(n,a, sal, mS)
        {
            this.company = c;
        }

        public override void Print()
        {
            Console.WriteLine($"\n\tSecurity name: {name}, age: {age} years, company: {company}, salary: {salary} usd, marriage: {(maritalStatus ? "Yes" : "No")}");
        }
    }

    public class Manager : Worker
    {
        public string company { get; set; }
        public int experiance { get; set; }
        public Manager(string n, int a, int sal, bool mS, string c, int experiance) : base(n, a, sal, mS)
        {
            this.company = c;
            this.experiance = experiance;
        }

        public override void Print()
        {
            Console.WriteLine($"\n\tManager name: {name}, age: {age} years, company: {company}, experiance: {experiance} years, salary: {salary} usd, marriage: {(maritalStatus ? "Yes" : "No")}");
        }
    }
    public class Engineer : Worker
    {
        public string company { get; set; }
        public int experiance { get; set; }
        public Engineer(string n, int a, int sal, bool mS, string c, int experiance) : base(n, a, sal, mS)
        {
            this.company = c;
            this.experiance = experiance;
        }

        public override void Print()
        {
            Console.WriteLine($"\n\tEngineer name: {name}, age: {age} years, company: {company}, experiance: {experiance} years, salary: {salary} usd, marriage: {(maritalStatus ? "Yes" : "No")}");
        }
    }
}
