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
        
        public void ParseFirstButton()
        {
            
            IWebDriver driver = new PhantomJSDriver();
            driver.Navigate().GoToUrl(@"https://www.tisbi.ru/postupit/");
            IWebElement tag = driver.FindElement(By.ClassName(@"covid-message"));
            string text = tag.Text;
            Console.Clear();
            Console.WriteLine(text);
        }

        public void ParseSecondButton()
        {

            IWebDriver driver = new PhantomJSDriver();
            driver.Navigate().GoToUrl(@"https://www.tisbi.ru/postupit/");
            IWebElement tag = driver.FindElement(By.ClassName(@"covid-scheme"));
            string text = tag.Text;
            Console.Clear();
            Console.WriteLine(text);
        }

        public void ParseThirdButton()
        {

            IWebDriver driver = new PhantomJSDriver();
            driver.Navigate().GoToUrl(@"https://www.tisbi.ru/postupit/");
            Console.Clear();
            for (int i = 3; i <= 11; i++)
            {
                
                IWebElement tag = driver.FindElement(By.XPath($@"(//div[contains(@class,'postupit-tabs__text')])[{i}]"));
                string text = tag.Text;   
                Console.WriteLine(text);
            }
            
        }

        public void ParseFourthButton()
        {

            IWebDriver driver = new PhantomJSDriver();
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
