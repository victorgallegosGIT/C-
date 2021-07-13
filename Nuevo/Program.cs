using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;

namespace Nuevo
{
    class Program
    {
        static void Main(string[] args)
        { 


            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php/");
            driver.Manage().Window.Maximize(); //maximizar
            IWebElement input = driver.FindElement(By.XPath("//a[contains(text(),'Sign in')]"));
            input.Click();
            IWebElement input2 = driver.FindElement(By.CssSelector("#email"));
            input2.SendKeys("victorgallegos@iresm.edu.ar");
            IWebElement BotonSerch = driver.FindElement(By.CssSelector("#passwd"));
            BotonSerch.SendKeys("hola1234");
            IWebElement BotonSerchclic = driver.FindElement(By.CssSelector("#SubmitLogin"));
            BotonSerchclic.Click();



        }
    }
}
