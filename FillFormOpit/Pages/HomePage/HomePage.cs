using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace FillFormOpit.Pages.HomePage
{
    public class HomePage : BasePage
    {


        public HomePage(IWebDriver driver) : base(driver)
        {

        }


        //public IWebElement CategoryNameButton(string categoryName) => Driver.FindElement(By.ClassName(categoryName));

        //public IWebElement CategoryNameButton(string categoryName) => Driver.FindElement(By.TagName(categoryName));

        public IWebElement CategoryNameButton(string categoryName) => Driver.FindElement(By.XPath($"//*[normalize-space(text())='{categoryName}']/ancestor::div[contains(@class, 'top-card')]"));

    }
}
