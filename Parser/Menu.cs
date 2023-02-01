﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
    internal class Menu
    {
        public void StartMenu()
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

        public void TisbiMenu()
        {
            var parserTisbiRu = new ParserTisbiRu();
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
                    parserTisbiRu.Parse();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("меню при нажатии 2");
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("меню при нажатии 3");
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("меню при нажатии 4");
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
