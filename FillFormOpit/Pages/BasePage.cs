using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace FillFormOpit.Pages
{
    public abstract class BasePage
    {

        public IWebDriver Driver { set; get; }

        public Actions Actions { set; get; }

        public WebDriverWait Wait { set; get; } 


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
