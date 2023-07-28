using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    public abstract class Device
    {
        public string name {  get; set; }
        public string description { get; set; }
        public int year { get; set; }
        public int volume { get; set; }

        public Device(string name, string description, int year, int volume)
        {
            this.name = name;
            this.description = description;
            this.year = year;
            this.volume = volume;
        }

        public abstract void Sound();
        public abstract void ShowName();
        public abstract void ShowDescription();
    }

    public class Cattle: Device
    {        
        public Cattle(string n, string desc, int y, int vol) : base(n, desc, y, vol) 
        { }

        public override void Sound()
        {
            Console.WriteLine("Cattle sounds");
        }
        public override void ShowName()
        {
            Console.WriteLine($"Cattle name: {name}");
        }
        public override void ShowDescription()
        {
            Console.WriteLine($"Cattle description: {description}");
        }
        public override string ToString()
        {
            return $"\nCattle name: {name}\n\tdescription: {description}\n\tmade in: {year}\n\tvolume: {volume} l";
        }
    }

    public class Microwave: Device
    {
        public double power { get; set; }
        public Microwave(string n, string desc, int y, int vol, double power) : base(n, desc, y, vol)
        {
            this.power = power;
        }

        public override void Sound()
        {
            Console.WriteLine("Microwave sounds");
        }
        public override void ShowName()
        {
            Console.WriteLine($"Microwave name: {name}");
        }
        public override void ShowDescription()
        {
            Console.WriteLine($"Microwave description: {description}");
        }
        public override string ToString()
        {
            return $"\nMicrowave name: {name}\n\tdescription: {description}\n\tmade in: {year}\n\tvolume: {volume} l\n\tpower: {power} kWt";
        }
    }

    public class Car : Device
    {
        public int WheelsSize { get; set; }
        public int power { get; set; }
        public Car(string n, string desc, int y, int vol, int WS, int power) : base(n, desc, y, vol)
        { 
            WheelsSize = WS;
            this.power = power;
        }

        public override void Sound()
        {
            Console.WriteLine("Car sounds");
        }
        public override void ShowName()
        {
            Console.WriteLine($"Car name: {name}");
        }
        public override void ShowDescription()
        {
            Console.WriteLine($"Car description: {description}");
        }
        public override string ToString()
        {
            return $"\nCar name: {name}\n\tdescription: {description}\n\tmade in: {year}\n\tengine volume: {volume} cm3\n\twheels size: {WheelsSize} in\n\tpower: {power} hp";
        }
    }
}
