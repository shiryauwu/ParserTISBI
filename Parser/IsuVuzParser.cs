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
            IWebElement _login = driver.FindElement(By.XPath(@"//input[contains(@name,'Login')]"));
            Thread.Sleep(2000);
            IWebElement _password = (IWebElement)driver.FindElements(By.XPath(@"//input[contains(@name,'Password')]"));
            Thread.Sleep(2000);
            _login.SendKeys(login);
            Thread.Sleep(2000);
            _password.SendKeys(password);
        }

    }
}
