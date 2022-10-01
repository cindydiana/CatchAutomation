using CatchAutomation.POM;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CatchAutomation
{
    [TestClass]
    public class UnitTest1
    {
        public IWebDriver driver = new ChromeDriver();

        [TestMethod]
     public void TestSignIn() {
        
        driver.Navigate().GoToUrl("https://closingportal.rocketmortgage.com");



            HomePage a = new HomePage(driver);

            a.CatchSignIn();

            driver.Quit();







        }








    }
}
