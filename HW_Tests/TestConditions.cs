using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Tests
{
    public class TestConditions
    {
        public ChromeDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver
            {
                Url = "http://automationpractice.com"
            };
            driver.FindElement(By.XPath("//a[@class='login']")).Click();
            driver.FindElement(By.XPath("//input[@id='email']")).SendKeys("vish262@mail.ru");
            driver.FindElement(By.XPath("//input[@id='passwd']")).SendKeys("qwerty");
            driver.FindElement(By.XPath("//button[@id='SubmitLogin']")).Click();
        }

    }
}