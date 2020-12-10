using AutoFixture;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.IO;
using System.Reflection;

namespace FillFormOpit
{

    [TestFixture]
    public class BaseTest
    {

        public IWebDriver Driver { get; set; }

        public Actions Builder { get; set; }

        protected Fixture Fixture => new Fixture();

        public void Initialize()
        {
            Driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            Builder = new Actions(Driver);
        }
    }
}