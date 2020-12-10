using NUnit.Framework;
using NUnitTestProject1.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1.Tests
{
    [TestFixture]
    class ElementsPageNavigation : BaseTest
    {

       
        private WebsiteHomepage _websiteHomepage;



        [SetUp]
        public void SetUp()
        {
             Initialize();

            //_driver = new ChromeDriver();
            _websiteHomepage = new Pages.WebsiteHomepage(Driver);
            

        }

        [Test]
        
        public void Elements()
        {

            Driver.Navigate().GoToUrl("https://demoqa.com/");
            //_driver.Url = "https://demoqa.com/";

            _websiteHomepage.clickOverElements();
        }

        [TearDown]

        public void TearDown()
        {
            //_driver.Quit();
        }


    }
}
