using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Correios
{
    [Binding]
    public class CorreiosStepDefinitions
    {
        private ChromeDriver _driver;
        public CorreiosStepDefinitions()
        {
            _driver = new ChromeDriver();
        }

        [TearDown]
        public void TearDown()
        {
            _driver.Dispose();
        }

        [Given(@"que estou na página ""(.*)""")]
        public void GivenIVsitSite(string url)
        {
            Console.WriteLine(url);
            _driver.Navigate().GoToUrl(url);
        }

        [When(@"eu digito o CEP (.*) no campo CEP correto")]
        public void WhenItypetheCEP(string cep)
        {
            IWebElement el = _driver.FindElementByName("relaxation");
            el.Click();
            el.SendKeys(cep);
        }

        [When(@"eu clico no botão ""(.*)""")]
        public void WhenclickonthebuttonBuscar(string buttonValue)
        {
            _driver.FindElementByCssSelector($"input[type=submit][value={buttonValue}]").Click();
        }

        [Then(@"eu recebo a mensagem ""(.*)""")]
        public void ThenIgetamessageDadosnoencontrado(string expectedResult)
        {
            string result = _driver.FindElementByXPath("/html/body/div[1]/div[3]/div[2]/div/div/div[2]/div[2]/div[2]/p").Text;

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Then(@"ao clicar no link ""(.*)""")]
        public void ThenAoClicarNoLink(string menuLink)
        {
            _driver.FindElementByLinkText(menuLink);
        }

        [Then(@"retorna para a tela inicial de busca CEP")]
        public void ThenRetornaParaATelaInicialDeBuscaCEP()
        {
            IWebElement el = _driver.FindElementByName("relaxation");
            Assert.That(el != null);
        }


    }
}
