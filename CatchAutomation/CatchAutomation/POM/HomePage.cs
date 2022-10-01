using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V102.Network;

namespace CatchAutomation.POM
{
    public class HomePage
    {

        //construtor
         public HomePage(IWebDriver Driver) {
            this.driver = Driver;
        }

            //section 1
            IWebDriver driver;

            IWebElement EmailAddress => driver.FindElement(By.XPath("//input[@id='email-text-input']"));

            IWebElement Password => driver.FindElement(By.XPath("//input[@id='password-text-input']"));

            IWebElement SignIn => driver.FindElement(By.XPath("//button[@id='sign-in-button']"));


        // section 2

      
            public void CatchSignIn()
        {
            EmailAddress.SendKeys("SyntheticMonitorAgent1@rocketmortgage.com");

            Password.SendKeys("Catch1234");

            SignIn.Click();

        }










    }
}
