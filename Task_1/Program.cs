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
    internal class Program
    {
        static void Main(string[] args)
        {
            Product[] products ={ new Product ( 12.5555555, "Cleaning brush", "Cleaning tools"),
                                  new Product ( 13.5456, "Washing table", "Cleaning tools"),
                                  new Product ( 45,1080, "Handle", "Bycicle parts"),
                                  new Product ( 35.5445, "Button", "Electronics"),
                                  new Product ( 12.50, "Tire", "Avtomotion")};
            Console.WriteLine("\n\tList of the Products:\n");
            foreach(var a in products)
            {
                Console.WriteLine(a.ToString());
            }
            Console.WriteLine();
            Console.WriteLine("\n\tReduce products price on 1.5:\n");
            foreach (var a in products)
            {
                a.ReducePrice(1.5);
                Console.WriteLine(a);
            }

            Money money = new Money(350, 45);
            Money money1 = new Money(200, 60);
            Console.WriteLine($"\nObjects Money:\n\tmoney = {money}\tmoney1 = {money1}");
            Console.WriteLine($"Their summ:\n\tmoney+money1 = {Money.Summ(money, money1)}");
        }
    }
}