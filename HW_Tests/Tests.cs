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
    class Tests : TestConditions
    {
        [Test]
        public void AddFadedShortSleeveTshirtIntoCart()
        {
            driver.FindElement(By.XPath("//a[@class='sf-with-ul']")).Click();
            driver.FindElement(By.XPath("//a/i[@class='icon-th-list']")).Click();
            driver.FindElement(By.XPath("//li[@class='ajax_block_product first-in-line first-item-of-tablet-line first-item-of-mobile-line col-xs-12']//span[contains(text(),'Add to cart')]")).Click();
            driver.FindElement(By.XPath("//span[@title='Close window']")).Click();
            driver.FindElement(By.XPath("//a[@title='View my shopping cart']")).Click();
        }
    }
}