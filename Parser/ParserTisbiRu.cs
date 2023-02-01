using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.PhantomJS;


namespace Parser
{
    internal class ParserTisbiRu
    {
        public void Parse()
        {
            
            IWebDriver driver = new PhantomJSDriver();
            driver.Navigate().GoToUrl(@"https://www.tisbi.ru/postupit/");
            string text = driver.Url;

            Console.WriteLine(text);
        }
    }
}
