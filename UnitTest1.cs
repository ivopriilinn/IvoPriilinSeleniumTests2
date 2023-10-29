using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using OpenQA.Selenium.Interactions;
using System.Collections.ObjectModel;
using System.Threading;

namespace IvoPriilinSeleniumTests2
{
    public class Tests
    {

        IWebDriver driver;
        String test_url = "https://ivopriilinn22.thkit.ee/";
        private readonly Random _random = new Random();

        [SetUp]
        public void start_browser()
        {
            driver = new ChromeDriver(); //("C:\\Users\\ivopr\\Desktop\\Kool\\Sooritamisel ained\\Tarkvara süsteemide testimine\\Selenium\\IvoPriilinSeleniumTests2\\drivers\\");
            driver.Manage().Window.Maximize();
        }
        // testib blogi linki (Testing blog link)
        [Test]
        public void test_page1()
        {
            driver.Url = test_url;
            Thread.Sleep(3000);
            IWebElement element = driver.FindElement(By.XPath("//*[@id=\"menu-item-1839\"]/a"));
            element.Click();
            Thread.Sleep(5000);
        }

        // testib vigast blogi linki (Testing faulty blog link)
        [Test]
        public void test_page2()
        {
            driver.Url = test_url;
            Thread.Sleep(3000);
            IWebElement element = driver.FindElement(By.XPath("//*[@id=\"menu_viga-1839\"]/a"));
            element.Click();
            Thread.Sleep(3000);
        }
        // Testib Earth nimelist home linki (Testing home link named Earth)
        [Test]
        public void test_page3()
        {
            driver.Url = test_url;
            Thread.Sleep(2500);
            IWebElement element = driver.FindElement(By.XPath("//*[@id=\"ast-desktop-header\"]/div[1]/div/div/div/div[1]/div/div/span/a"));
            element.Click();
            Thread.Sleep(2500);
        }

        // testib home linki (vasakul yleval)/ Testing home link (up-left)
        [Test]
        public void test_page4()
        {
            driver.Url = test_url;
            Thread.Sleep(2500);
            IWebElement element = driver.FindElement(By.XPath("//*[@id=\"menu-item-1808\"]/a"));
            element.Click();
            Thread.Sleep(2500);
        }

        // testib about linki (Testing about link)
        [Test]
        public void test_page5()
        {
            driver.Url = test_url;
            Thread.Sleep(2500);
            IWebElement element = driver.FindElement(By.XPath("//*[@id=\"menu-item-1666\"]/a"));
            element.Click();
            Thread.Sleep(2500);
        }

        // testib contact linki (Testing contact link)
        [Test]
        public void test_page6()
        {
            driver.Url = test_url;
            Thread.Sleep(2500);
            IWebElement element = driver.FindElement(By.XPath("//*[@id=\"menu-item-1667\"]/a"));
            element.Click();
            Thread.Sleep(2500);
        }

        [TearDown]
        public void close_Browser()
        {
            driver.Close();
        }
    }
} 