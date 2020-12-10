using FillFormOpit.Factory;
using FillFormOpit.Model;
using FillFormOpit.Pages.ElementsPage;
using FillFormOpit.Pages.HomePage;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace FillFormOpit.Tests.ElementsPage
{

    [TestFixture]
    class TextBoxElementsPageTest : BaseTest
    {

        private HomePage _homePage;
        private ElementsPageTextBox _elementsPageTextBox;
        private FormModel _user;



        [SetUp]
        public void SetUp()
        {
            Initialize();
            _homePage = new HomePage(Driver);
            _elementsPageTextBox = new ElementsPageTextBox(Driver);
            _user = FormFactory.Create();

            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("https://demoqa.com/");
           

        }




        [Test]
        public void SelectPage()
        {
            _homePage.ScrollTo(_homePage.CategoryNameButton("Elements"));

            _homePage.CategoryNameButton("Elements").Click();

            _elementsPageTextBox.SelectTextBox();


            _elementsPageTextBox.FillTextBox(_user);

            

            // open homapage and click over selected page to be open then select section "text box"
        }


        



        [TearDown]

        public void TearDown()
        {
            //Driver.Close();
        }
    }
}
