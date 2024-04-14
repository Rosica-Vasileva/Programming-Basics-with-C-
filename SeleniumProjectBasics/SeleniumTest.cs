using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumWebDriverProject.FirstTest
{
    public class Tests
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            // Инициализация на ChromeDriver
            driver = new ChromeDriver();
        }

        [Test]
        public void GoogleSearchTest()
        {
            // Навигация до Google
            driver.Navigate().GoToUrl("https://www.google.com");

            // Въвеждане на ключова дума в търсачката
            IWebElement searchBox = driver.FindElement(By.Name("q"));
            searchBox.SendKeys("Selenium testing");
            searchBox.SendKeys(Keys.Return);

            // Проверка на резултатите от търсенето
            Assert.IsTrue(driver.Title.Contains("Selenium testing"));
        }

        [TearDown]
        public void TearDown()
        {
            // Затваряне на браузъра
            driver.Quit();
        }
    }
}
