using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Задание 3
//Создать базовый класс «Музыкальный инструмент» 
//и производные классы «Скрипка», «Тромбон», «Укулеле»,«Виолончель».
//С помощью конструктора установить имя каждого музыкального инструмента и его характеристики.
//Реализуйте для каждого из классов методы:
//■ Sound — издает звук музыкального инструмента 
//(пишем текстом в консоль);
//■ Show — отображает название музыкального инструмента;
//■ Desc — отображает описание музыкального инструмента;
//■ History — отображает историю создания музыкального инструмента.
namespace Task_3
{
    public abstract class Music_Instrument
    {
        public string name { get; set; }
        public string description { get; set; }
        public string history { get; set; }
        public int year { get; set; }

        public Music_Instrument(string name, string description, string history, int year)
        {
            this.name = name;
            this.description = description;
            this.history = history;
            this.year = year;
        }

        public abstract void Sound();

        public abstract void ShowName();

        public abstract void ShowDescription();
        public abstract void ShowHistory();
    }

    public class Skrypka: Music_Instrument
    {
        public string maker { get; set; }

        public Skrypka(string n, string desc, string his, int y, string maker) : base(n,desc,his,y)
        {
            this.maker = maker;
        }

        public override void Sound()
        {
            Console.WriteLine("Skrypka sounds");
        }
        public override void ShowName()
        {
            Console.WriteLine($"Skrypka name: {name}");
        }
        public override void ShowDescription()
        {
            Console.WriteLine($"Skrypka description: {description}");
        }
        public override void ShowHistory()
        {
            Console.WriteLine($"Skrypka history: {history}");
        }

        public override string ToString()
        {
            return $"\nSkrypka name: {name}\n\tmaker: {maker}\n\tdescription: {description}\n\tmade in: {year}\n\thistory: {history}";
        }
    }
    public class Trombone : Music_Instrument
    {
        public string material { get; set; }

        public Trombone(string n, string desc, string his, int y, string material) : base(n, desc, his, y)
        {
            this.material = material;
        }

        public override void Sound()
        {
            Console.WriteLine("Trombone sounds");
        }
        public override void ShowName()
        {
            Console.WriteLine($"Trombone name: {name}");
        }
        public override void ShowDescription()
        {
            Console.WriteLine($"Trombone description: {description}");
        }
        public override void ShowHistory()
        {
            Console.WriteLine($"Trombone history: {history}");
        }
        public override string ToString()
        {
            return $"\nTrombone name: {name}\n\tmaterial: {material}\n\tdescription: {description}\n\tmade in: {year}\n\thistory: {history}";
        }
    }

    public class Ukulele : Music_Instrument
    {
        public string MadeCountry { get; set; }

        public Ukulele(string n, string desc, string his, int y, string m) : base(n, desc, his, y)
        {
            this.MadeCountry = m;
        }

        public override void Sound()
        {
            Console.WriteLine("Ukulele sounds");
        }
        public override void ShowName()
        {
            Console.WriteLine($"Ukulele name: {name}");
        }
        public override void ShowDescription()
        {
            Console.WriteLine($"Ukulele description: {description}");
        }
        public override void ShowHistory()
        {
            Console.WriteLine($"Ukulele history: {history}");
        }
        public override string ToString()
        {
            return $"\nUkulele name: {name}\n\tmade in: {MadeCountry}\n\tdescription: {description}\n\tmade in: {year}\n\thistory: {history}";
        }
    }

    public class Viola : Music_Instrument
    { 

        public Viola(string n, string desc, string his, int y) : base(n, desc, his, y)
        { }

        public override void Sound()
        {
            Console.WriteLine("Viola sounds");
        }
        public override void ShowName()
        {
            Console.WriteLine($"Viola name: {name}");
        }
        public override void ShowDescription()
        {
            Console.WriteLine($"Viola description: {description}");
        }
        public override void ShowHistory()
        {
            Console.WriteLine($"Viola history: {history}");
        }
        public override string ToString()
        {
            return $"\nViola name: {name}\n\tdescription: {description}\n\tmade in: {year}\n\thistory: {history}";
        }
    }
}
