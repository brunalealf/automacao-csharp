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
            Console.WriteLine(result);
            Console.WriteLine($"expected result > {expectedResult}");
            // TODO precisa haver um assert aqui
            _driver.Dispose();
        }

    }
}
