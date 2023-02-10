using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Parser
{
    public class IsuVuzParser: ParserTisbiRu
    {

        

        public void StartParse()
        {
            var date = DateTime.Now.ToString("d");
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
            Thread.Sleep(3000);
            driver.FindElement(By.XPath(@"//button[@type='button'][contains(.,'Начать работу')]")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.XPath(@"//a[contains(@data-toggle,'dropdown')]")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath(@"//a[@class='dropdown-item'][contains(.,'Расписание занятий')]")).Click();
            Console.Clear();
            Thread.Sleep(5000);
            for (int i = 0; i <= 10; i++)
            {
                try
                {
                    Console.WriteLine(driver.FindElement(By.XPath($@"(//td[@class='align-middle table-primary'])[{i}]")).Text);
                    Console.WriteLine(" ");
                }
                catch(Exception e)
                {
                    continue;
                }
            }
        }

    }
}
