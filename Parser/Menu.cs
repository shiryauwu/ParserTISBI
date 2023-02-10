using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
    internal class Menu: ParserTisbiRu
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
                    IsuVuzMenu();
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Введите число!");
                    break;
            }
        }
        public void IsuVuzMenu()
        {
            var parserIsuVuz = new IsuVuzParser();
            Console.Clear();
            string choose;
            
            parserIsuVuz.StartParse();
            Console.WriteLine("1. Распмсание");
        }
        public void TisbiMenu()     //Меню для парсинга сайта ТИСБИ
        {
            
            Console.Clear();
            string choose;
            Console.WriteLine("1. Информация о подаче документов.");
            Console.WriteLine("2. Перечень документов для поступления.");
            Console.WriteLine("3. Основные даты для поступления на бюджет.");
            Console.WriteLine("4. Основные даты для поступления на коммерцию.");
            Console.WriteLine("5. Схема поступления");
            Console.WriteLine("6. Вступительные испытания");
            Console.WriteLine("7. Как проходит зачисление");
            Console.WriteLine("8. Расписание онлайн-консультаций с приемной комиссией");
            Console.WriteLine("9. Расписание онлайн-консультаций с деканами факультетов");
            Console.WriteLine("0.Расписание онлайн Дней открытых дверей");
            Console.WriteLine("10. Назад в главное меню.");

            choose = Console.ReadLine();
            switch (choose)
            {
                case "1":
                    Console.Clear();
                    ParseFirstButton();
                    break;
                case "2":
                    Console.Clear();
                    ParseSecondButton();
                    break;
                case "3":
                    Console.Clear();
                    ParseThirdButton();
                    break;
                case "4":
                    Console.Clear();
                    ParseFourthButton();
                    break;
                case "5":
                    Console.Clear();
                    ParseFiveButton();
                    break;
                case "6":
                    Console.Clear();
                    ParserSixthButton();
                    break;
                case "7":
                    Console.Clear();
                    ParserSeventhButton();
                    break;
                case "8":
                    Console.Clear();
                    ParserEigthButton();
                    break;
                case "9":
                    Console.Clear();
                    ParserNinethButton();
                    break;

                case "0":
                    Console.Clear();
                    ParserTenthButton();
                    break;
                case "10":
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
