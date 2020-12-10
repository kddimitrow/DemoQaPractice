using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1.Pages
{
    class WebsiteHomepage : BasePage
    {

       public  WebsiteHomepage(IWebDriver driver) :base(driver)
        {

        }


        public IWebElement elementsButtonPage => Driver.FindElement(By.XPath("/html/body/div/div/div/div[2]/div/div[1]/div/div[3]/h5"));

        public void clickOverElements()
        {

            ScrollTo(elementsButtonPage);
            elementsButtonPage.Click();
        }

    }
}
