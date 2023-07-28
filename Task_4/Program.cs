//Задание 4
//Создать абстрактный базовый класс Worker (работника) 
//с методом Print(). Создайте четыре производных класса: 
//President, Security, Manager, Engineer. Переопределите метод
//Print() для вывода информации, соответствующей 
//каждому типу работника.

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker[] worker = { new President("Aleks Ysik",35,10000,true,"Ukraine"),
                                new Security("Ivan Ivanov", 30, 500, false, "Pantera"),
                                new Manager("Vasiliy Proday",33, 700, false,"Kupi-Proday", 5),
                                new Engineer("Petr Konovalov", 45, 1000, true, "Building truth", 20)};
            foreach (var d in worker)
            {               
                d.Print();
                Console.WriteLine("\n\n");
            }
        }
    }
}