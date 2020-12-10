using FillFormOpit.Model;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace FillFormOpit.Pages.ElementsPage
{
    class ElementsPageTextBox : BasePage
    {

     public ElementsPageTextBox(IWebDriver driver) : base( driver)
        {

        }




        public IWebElement TextBoxSection => Driver.FindElement(By.Id("item-0"));



        public void SelectTextBox()
        {
           TextBoxSection.Click();

           // primer za action:  Actions.Click(TextBoxSection).SendKeys("a").Perform();
        }



        public IWebElement FullName => Driver.FindElement(By.Id("userName"));

        public IWebElement Email => Driver.FindElement(By.Id("userEmail"));

        public IWebElement CurrentAdress => Driver.FindElement(By.Id("currentAddress"));

        public IWebElement PermanentAdress => Driver.FindElement(By.Id("permanentAddress"));

        public IWebElement SubmitButton => Driver.FindElement(By.Id("submit"));


        public void FillTextBox(FormModel user)
        {

            FullName.SendKeys(user.FullName);
            Email.SendKeys(user.EmailAdd);
            CurrentAdress.SendKeys(user.CurrentAddress);
            PermanentAdress.SendKeys(user.CurrentAddress);

            SubmitButton.Click();

        }


    }
}
