using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

//Задание 1
//Запрограммируйте класс Money (объект класса оперирует одной валютой) для работы с деньгами.
//В классе должны быть предусмотрены поле для хранения целой части денег (доллары, евро, гривны и т.д.) и поле 
//для хранения копеек (центы, евроценты, копейки и т.д.).
//Реализовать методы для вывода суммы на экран, задания значений для частей. 
//На базе класса Money создать класс Product для работы с продуктом или товаром.
//Реализовать метод, позволяющий уменьшить цену на заданное число.
//Для каждого из классов реализовать необходимые методы и поля.

namespace Task_1
{
    internal class Money
    {
        public int integ { get; set; }
        public int coins { get; set; }
        
        public Money () { }

        public Money(double num)
        {
            int temp =Convert.ToInt32(num*100);
            this.integ = temp/100;
            this.coins = temp%100;
        }
        public Money (int integ, int coins)
        {           
            if (coins>100)
            {
                this.coins = coins%100;
                this.integ = integ + coins/100;
            }
            else
            {
                this.integ = integ;
                this.coins = coins;
            }            
        }
        public static Money Summ(Money a, Money b)
        {
            Money temp = new Money();
            temp.integ= a.integ + b.integ;
            temp.coins= a.coins + b.coins;
            if (temp.coins >= 100)
            {
                temp.integ += temp.coins / 100;
                temp.coins %= 100;
            }
            return temp;
        }
        public override string ToString()
        {
            string a = "";
            a = coins < 10 ? $"0{coins}" : coins.ToString();
            return $"{integ}.{a}";
        }

    }
}
