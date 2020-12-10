using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitTestProject1.Pages
{
    public class BasePage
    {

        public virtual string Url { get; }

        public IWebDriver Driver { get; }

        public WebDriverWait Wait { get;  }

        public Actions Actions { get; }



        public BasePage(IWebDriver driver)
        {
            Driver = driver;
            Actions = new Actions(driver);
            Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
        }

        public void ScrollTo(IWebElement element)
        {
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }



    }
}
