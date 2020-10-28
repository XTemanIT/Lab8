using System;
using System.Collections.Generic;

namespace Lab1CSharp
{
    class Garage
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
        public int Speed { get; set; }
        public virtual void GetInfo() { }
    }
    class Car : Garage
    {
        public string name, color;
        public int age, speed;

        public Car(string name, string color, int age, int speed)
        {
            this.name = name;
            this.color = color;
            this.age = age;
            this.speed = speed;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Имя: {name}\nЦвет: {color}\nГод: {age}\nСкорость: {speed}\n");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int select;
            string name, color, str;
            int age, speed, N;
            List<Garage> garage = new List<Garage>();
            garage.Add(new Car("Taycan", "Emerald", 2020, 340));
            garage.Add(new Car("S63s", "Black", 2020, 360));
            garage.Add(new Car("G63", "Black", 2020, 320));
            garage.Add(new Car("GTRPro", "Black", 2020, 350));
            garage.Add(new Car("LandCr200", "Black", 2020, 280));
            do
            {
                Console.WriteLine("Menu: ");
                Console.WriteLine("Info about Cars - 1");
                Console.WriteLine("Add Car - 2");
                Console.WriteLine("Delete Car - 3");
                Console.WriteLine("Get Car for driving - 4");
                Console.WriteLine("Exit - 9");
                select = Convert.ToInt32(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        for (int i = 0; i < garage.Count; i++)
                        {
                            garage[i].GetInfo();
                        }
                        break;
                    case 2:
                        name = Convert.ToString(Console.ReadLine());
                        color = Convert.ToString(Console.ReadLine());
                        age = Convert.ToInt32(Console.ReadLine());
                        speed = Convert.ToInt32(Console.ReadLine());
                        garage.Add(new Car(name, color, age, speed));
                        Console.WriteLine("Car added");
                        break;
                    case 3:
                        N = Convert.ToInt32(Console.ReadLine());
                        garage.RemoveAt(N);
                        Console.WriteLine("Car deleted");
                        break;
                    case 4:
                        /*str = Convert.ToString(Console.ReadLine());
                        Garage car = garage.Find(item => item.Name == str);
                        Console.WriteLine("Название: {0}", car.Name);*/
                        break;
                    default:
                        Console.WriteLine("Bad Input");
                        break;
                }
            } while (select != 9);   
        }
    }
}
