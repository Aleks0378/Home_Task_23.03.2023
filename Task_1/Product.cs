using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Задание 1
//Запрограммируйте класс Money (объект класса оперирует одной валютой) для работы с деньгами.
//В классе должны быть предусмотрены поле для хранения целой части денег (доллары, евро, гривны и т.д.) и поле 
//для хранения копеек (центы, евроценты, копейки и т.д.).
//Реализовать методы для вывода суммы на экран, задания значений для частей. 
//На базе класса Money создать класс Product для работы 
//с продуктом или товаром. Реализовать метод, позволяющий уменьшить цену на заданное число.
//Для каждого из классов реализовать необходимые методы и поля.

namespace Task_1
{
    internal class Product: Money
    {
        public string name { get; set; }
        public string category { get; set; }
        public Product() { }
        public Product(double price, string name, string category):base(price)
        {
            this.name = name;
            this.category = category;
        }
        public Product(int integ, int coin, string name, string category) : base(integ,coin)
        {
            this.name = name;
            this.category = category;
        }
        public void ReducePrice(double a)
        {
            int temp = Convert.ToInt32(a * 100);
            int a1 = temp/100, a2 = temp%100;
            if (this.integ > a1) this.integ -= a1;
            else this.integ = 0;
            if (this.coins >= a2) this.coins -= a2;
            else
            {
                if (this.integ > 0) { this.coins = 100 - (a2 - this.coins); --this.integ; }
                else this.coins = 0;
            }
        }
        public void ReducePrice(int a)
        {
            if (this.integ > a) this.integ -= a;
            else this.integ = 0;
        }

        public override string ToString()
        {
            string a = "";
            a= coins < 10 ? $"0{coins}" : coins.ToString();
            return $"Product Name: {name},\tcategory: {category},\tprice: {integ}.{a}\n";
        }
    }
}
