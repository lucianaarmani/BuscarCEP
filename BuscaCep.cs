using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class BuscaCep : Begin
    {
        [Test]
        public void Teste()
        {
            driver.FindElement(By.Id("endereco")).SendKeys(" ");
            driver.FindElement(By.Id("btn_pesquisar")).Click();
            Assert.That(driver.FindElement(By.XPath("//*[@id=\"resultado-DNEC\"]/tbody/tr/td[1]")).Text, Does.Contain("Rua Deputado Eliseu Teixeira"));

        }
    }
}
