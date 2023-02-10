using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Parser
{
    internal class IsuVuzParser
    {

        IWebDriver driver = new ChromeDriver();

        public void StartParse()
        {
            Console.Clear();
            driver.Navigate().GoToUrl(@"https://isu.tisbi.ru/student/login");
            Console.Clear();
            Console.WriteLine("Введите Логин и пароль от аккаунта ИСУ ВУЗ(студент)");
            string login = Console.ReadLine();
            string password = Console.ReadLine();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath(@"//input[contains(@name,'Login')]")).SendKeys(login);
            Thread.Sleep(2000);


            driver.FindElement(By.XPath(@"//input[contains(@name,'Password')]")).SendKeys(password);
            
            Thread.Sleep(2000);
            driver.FindElement(By.XPath(@"//button[@type='button'][contains(.,'Войти')]")).Click();
        }

    }
}
