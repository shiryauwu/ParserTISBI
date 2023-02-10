using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using static System.Net.Mime.MediaTypeNames;


namespace Parser
{
    public class ParserTisbiRu
    {
        public IWebDriver driver = new ChromeDriver();
        

        

        
        
        public void ParseFirstButton()                    //Парсит инфу для абитуриентов
        {
            
            Console.Clear();    
            driver.Navigate().GoToUrl(@"https://www.tisbi.ru/postupit/");
            IWebElement tag = driver.FindElement(By.ClassName(@"covid-message"));
            string text = tag.Text;
            Console.Clear();
            Console.WriteLine(text);
        }

        public void ParseSecondButton()                   //Парсит инфу про документы
        {
            Console.Clear();
            driver.Navigate().GoToUrl(@"https://www.tisbi.ru/postupit/");
            IWebElement tag = driver.FindElement(By.ClassName(@"covid-scheme"));
            string text = tag.Text;
            Console.Clear();
            Console.WriteLine(text);
        }

        public void ParseThirdButton()                    //Парсит инфу про датя для бюджетников
        {
            Console.Clear();
            driver.Navigate().GoToUrl(@"https://www.tisbi.ru/postupit/");
            Console.Clear();
            for (int i = 3; i <= 11; i++)
            {
                
                IWebElement tag = driver.FindElement(By.XPath($@"(//div[contains(@class,'postupit-tabs__text')])[{i}]"));
                string text = tag.Text;   
                Console.WriteLine(text);
            }
            
        }

        public void ParseFourthButton()                     //Парсит даты для платников
        {
            Console.Clear();
            driver.Navigate().GoToUrl(@"https://www.tisbi.ru/postupit/");
            Console.Clear();
            for (int i = 12; i <= 16; i++)
            {

                IWebElement tag = driver.FindElement(By.XPath($@"(//div[contains(@class,'postupit-tabs__text')])[{i}]"));
                string text = tag.Text;
                
                Console.WriteLine(text);
            }
        }
        //Парсит Схему поступления
        public void ParseFiveButton()
        {
            Console.Clear();
            driver.Navigate().GoToUrl(@"https://www.tisbi.ru/postupit/");
            Console.Clear();

            for (int i = 14; i <= 23; i++)
            {

                IWebElement tag = driver.FindElement(By.XPath($@"(//li[contains(@class,'li')])[{i}]"));
                string text = tag.Text;

                Console.WriteLine(text);
            }
        }
        // Парсит вступительные испытания
        public void ParserSixthButton()
        {
            Console.Clear();
            driver.Navigate().GoToUrl(@"https://www.tisbi.ru/postupit/");
            Console.Clear();

            for (int i = 17; i <= 19; i++)
            {

                IWebElement tag = driver.FindElement(By.XPath($@"(//div[contains(@class,'postupit-tabs__text')])[{i}]"));
                string text = tag.Text;
                Console.WriteLine(text);
            }
        }
        // Как проходит зачисление
        public void ParserSeventhButton()
        {
            Console.Clear();
            driver.Navigate().GoToUrl(@"https://www.tisbi.ru/postupit/");
            Console.Clear();

            for (int i = 20; i <= 22; i++)
            {

                IWebElement tag = driver.FindElement(By.XPath($@"(//div[contains(@class,'postupit-tabs__text')])[{i}]"));
                string text = tag.Text;
                Console.WriteLine(text);
            }

            for (int i = 11; i <= 21; i++)
            {

                IWebElement tag = driver.FindElement(By.XPath($@"(//li[contains(@class,'postupit-tabs__li')])[{i}]"));
                string text = tag.Text;

                Console.WriteLine(text);
            }
        }

        // Расписание онлайн-консультаций с приемной комиссией

        public void ParserEigthButton()
        {
            Console.Clear();
            driver.Navigate().GoToUrl(@"https://www.tisbi.ru/postupit/");
            Console.Clear();

            for (int i = 23; i <= 26; i++)
            {

                IWebElement tag = driver.FindElement(By.XPath($@"(//div[contains(@class,'postupit-tabs__text')])[{i}]"));
                string text = tag.Text;
                Console.WriteLine(text);
            }
        }

        //Расписание онлайн-консультаций с деканами факультетов
        public void ParserNinethButton()
        {
            Console.Clear();
            driver.Navigate().GoToUrl(@"https://www.tisbi.ru/postupit/");
            Console.Clear();
            for (int i = 27; i <= 32; i++)
            {
                IWebElement tag = driver.FindElement(By.XPath($@"(//div[contains(@class,'postupit-tabs__text')])[{i}]"));
                string text = tag.Text;
                Console.WriteLine(text);
            }
        }
        // Расписание онлайн Дней открытых дверей
        public void ParserTenthButton()
        {
            Console.Clear();
            driver.Navigate().GoToUrl(@"https://www.tisbi.ru/postupit/");
            Console.Clear();

            for (int i = 33; i <= 37; i++)
            {
                IWebElement tag = driver.FindElement(By.XPath($@"(//div[contains(@class,'postupit-tabs__text')])[{i}]"));
                string text = tag.Text;
                Console.WriteLine(text);
            }
        }
    }
}
