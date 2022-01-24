using System.Collections;
using System.Text;
using System;

namespace cars
{
    public class Program
    {
       static void Main(string[] args)
        {
            
            var auto = new Autosalon();
            bool menu = true;
            while (menu)
            {
                menu = Menu(auto);
            }
        }

        private static bool Menu(Autosalon auto)
        {
            bool menu = true;
            Console.WriteLine("Выберете действие");
            Console.WriteLine("1) Добавление автомобиля.");
            Console.WriteLine("2) Удаление автомобиля.");
            Console.WriteLine("3) Показать список автомобилей.");
            Console.WriteLine("4) Выход");
            Console.Write("\r\nВнести свой выбор: ");

            switch (Console.ReadLine())
            {
                case "1":
                    {
                        auto.AddCars();
                        auto.Show();
                        break;
                    }
                case "2":
                    {
                        auto.DeleteCars();
                        break;
                    }

                case "3":
                    {
                        auto.Show();
                        break;
                    }

                case "4":
                    {
                        menu = false;
                        break;
                    }

            }

            return menu;
        }
    }
}






