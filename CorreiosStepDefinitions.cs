using NUnit.Framework;
using NUnit.Framework.Legacy;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace Correios
{
    [Binding]
    [Parallelizable(ParallelScope.Fixtures)]
    public class CorreiosStepDefinitions
    {
        private ChromeDriver _driver;
        public CorreiosStepDefinitions()
        {
            _driver = new ChromeDriver();
        }

        [AfterScenario]
        public void CloseTab()
        {
            _driver.Quit();
        }

        [Given(@"que ao acessar o site ""(.*)""")]
        public void GivenIVsitSite(string url)
        {
            Console.WriteLine(url);
            _driver.Navigate().GoToUrl(url);
        }

        [Given(@"eu digito o CEP (.*) no campo CEP correto")]
        [When(@"eu digito o CEP (.*) no campo CEP correto")]
        public void WhenItypetheCEP(string cep)
        {
            IWebElement el = _driver.FindElementByName("relaxation");
            el.Click();
            el.SendKeys(cep);
        }

        [Given(@"eu clico no botão ""(.*)""")]
        [When(@"eu clico no botão ""(.*)""")]
        public void WhenclickonthebuttonBuscar(string buttonValue)
        {
            _driver.FindElementByCssSelector($"input[type=submit][value={buttonValue}]").Click();
        }

        [Given(@"eu recebo a mensagem ""(.*)""")]
        [Then(@"eu recebo a mensagem ""(.*)""")]
        public void ThenIgetamessageDadosnoencontrado(string expectedResult)
        {
            string result = _driver.FindElementByXPath("/html/body/div[1]/div[3]/div[2]/div/div/div[2]/div[2]/div[2]/p").Text;

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [When(@"clicar no menu ""(.*)""")]
        public void ThenAoClicarNoLink(string menuLink)
        {
            _driver.FindElementByLinkText(menuLink).Click();
        }

        [Then(@"retorna para a tela inicial de busca ao CEP")]
        public void ThenRetornaParaATelaInicialDeBuscaCEP()
        {
            IWebElement el = _driver.FindElementByName("relaxation");
            Assert.That(el != null);
        }

        [Given(@"eu vejo na tabela de resultados ""(.*)""")]
        [Then(@"eu vejo na tabela de resultados ""(.*)""")]
        public void ThenEuVejoNaTabelaDeResultados(string expectedResult)
        {
            IWebElement el = _driver.FindElementByCssSelector("body > div.back > div.tabs > div:nth-child(2) > div > div > div.column2 > div.content > div.ctrlcontent > table > tbody > tr:nth-child(2) > td:nth-child(1)");
            Assert.That(el != null);
            StringAssert.Contains(expectedResult, el.Text);
        }

        [When(@"clicar no logo dos Correios")]
        public void WhenClicarNoLogoDosCorreios()
        {
            _driver.FindElementByCssSelector("img[title=\"Ir para a página incial\"]").Click();
        }

        [Then(@"retorna para a tela inicial do site dos Correios")]
        public void ThenRetornaParaATelaInicialDoSiteDosCorreios()
        {
            Assert.That(_driver.PageSource.Contains("Acompanhe seu Objeto") != false);
        }

        [Given(@"digitar o código de rastreamento ""(.*)""")]
        public void GivenDigitarOCodigoDeRastreamento(string trackingCode)
        {
            _driver.FindElementById("objeto").SendKeys(trackingCode);
        }

        [When("eu clico para consultar rastreio")]
        public void WhenEuClicoParaConsultarRastreio()
        {
            _driver.FindElementById("b-pesquisar").Click();
        }

        [Then(@"retorna uma mensagem informando ""(.*)""")]
        public void ThenRetornaUmaMensagemInformando(string message)
        {
            IWebElement el = _driver.FindElementByXPath("/html/body/main/div[1]/form/div[2]/div[2]/div[2]/div[3]");
            Assert.That(el != null);
            StringAssert.Contains(message, el.Text);
        }

        [Then("fechar a aba do browser")]
        public void ThenFecharAAbaDoBrowser()
        {
            // aguarda finalizar cen�rio
        }
    }
}
