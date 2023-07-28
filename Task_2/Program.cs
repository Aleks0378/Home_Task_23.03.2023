//Задание 2
//Создать базовый класс «Устройство» и производные 
//классы «Чайник», «Микроволновка», «Автомобиль», «Пароход». С помощью конструктора установить имя каждого 
//устройства и его характеристики.
//Реализуйте для каждого из классов методы:
//■ Sound — издает звук устройства (пишем текстом в 
//консоль);
//■ Show — отображает название устройства;
//■ Desc — отображает описание устройства.

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Device[] device = { new Cattle("Brown", "White cattle with green line", 2022, 1),
                                new Microwave("Gorenie", "Black body with gray door", 2021, 5, 3.5),
                                new Car("BMW","White car, full aplication", 2020, 3, 18, 200)};
            foreach (var d in device)
            {
                d.Sound();
                d.ShowName();
                d.ShowDescription();
                Console.WriteLine(d.ToString());
                Console.WriteLine("\n\n");
            }
           
        }
    }
}