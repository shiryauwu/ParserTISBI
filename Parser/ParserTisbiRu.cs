using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.PhantomJS;
using static System.Net.Mime.MediaTypeNames;


namespace Parser
{
    internal class ParserTisbiRu
    {
        IWebDriver driver = new PhantomJSDriver();
        string Text { get; set; }

        

        
        
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
    }
}
