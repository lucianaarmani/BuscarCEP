using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace TestProject
{
    public class Begin
    {
        public IWebDriver driver;
        public bool driverQuit = true;

        [SetUp]
        public void InicioTeste()
        {
            driver = new EdgeDriver();
            driver.Navigate().GoToUrl("http://www.buscacep.correios.com.br");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driverQuit = false;
        }
       
        [TearDown]
        public void FimTeste()
        {
          if (driverQuit) driver.Quit();
        }
       

    }
}