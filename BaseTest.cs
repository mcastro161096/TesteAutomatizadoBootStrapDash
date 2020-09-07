using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TesteAutomatizadoBootStrapDash
{
    public class BaseTest
    {
        public IWebDriver driver { get; set; }


        [TearDown]
        public void FecharNavegador()
        {
            driver.Close();
            driver.Quit();
            driver = null;
        }
        [SetUp]
        public void AbrirNavegador()
        {
            driver = new ChromeDriver();
            //ChromeOptions options = new ChromeOptions();
            //options.AddArgument("headless")hghjghjg;
            //driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
        }
        public void AbreUrl(string link)
        {
            driver.Navigate().GoToUrl(link);

        }

        public object BuscaValorDoElementoParaInputs(IWebDriver driver, IWebElement elemento)
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            var id = elemento.GetAttribute("id").ToString();

            var valorDoElemento = "";

            if (id != null)
            {
                valorDoElemento = executor.ExecuteScript($"return (document.getElementById('{id}').value)").ToString();
            }
            else
            {
                valorDoElemento = executor.ExecuteScript($"return (document.getElementById('{id}').value)").ToString();

            }

            return valorDoElemento;
        }

        public object BuscaValorDoElementoParaDropDowns(IWebDriver driver, IWebElement elemento)
        {
            var id = elemento.GetAttribute("id").ToString();

            var value = BuscaValorDoElementoParaInputs(driver, elemento).ToString();

            var valorDoElemento = driver.FindElement(By.CssSelector($"#{id} > option[value='{value}']"));


            return valorDoElemento.Text.ToString();
        }

        public object BuscaValorDoElementoQuerySelector(IWebDriver driver, string seletor)
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;

            var valorDoElemento = executor.ExecuteScript($"return document.querySelector('{seletor}').value");


            return valorDoElemento;
        }

    }
}
