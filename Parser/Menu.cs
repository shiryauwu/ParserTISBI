using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
    internal class Menu
    {
        public void StartMenu()  //Стартовое меню. Запускается при запуске проги
        {
            string choose;
            Console.WriteLine("Выбор сайта:");
            Console.WriteLine("1. tisbi.ru");
            Console.WriteLine("2. ИСУ ВУЗ");
            choose = Console.ReadLine();
            switch (choose)
            {
                case "1":
                    Console.Clear();
                    TisbiMenu();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("меню при нажатии 2");
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Введите число!");
                    break;
            }
        }

        public void TisbiMenu()     //Меню для парсинга сайта ТИСБИ
        {
            var parserTisbiRu = new ParserTisbiRu();
            Console.Clear();
            string choose;
            Console.WriteLine("1. Информация о подаче документов.");
            Console.WriteLine("2. Перечень документов для поступления.");
            Console.WriteLine("3. Основные даты для поступления на бюджет.");
            Console.WriteLine("4. Основные даты для поступления на коммерцию.");
            Console.WriteLine("5. Назад в главное меню.");

            choose = Console.ReadLine();
            switch (choose)
            {
                case "1":
                    Console.Clear();
                    parserTisbiRu.ParseFirstButton();
                    break;
                case "2":
                    Console.Clear();
                    parserTisbiRu.ParseSecondButton();
                    break;
                case "3":
                    Console.Clear();
                    parserTisbiRu.ParseThirdButton();
                    break;
                case "4":
                    Console.Clear();
                    parserTisbiRu.ParseFourthButton();
                    break;
                case "5":
                    Console.Clear();
                    StartMenu();
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Введите число!");
                    break;
            }


        }
    }
}
