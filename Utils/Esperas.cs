using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace TesteAutomatizadoBootStrapDash.Utils
{
    public class Esperas
    {
        public WebDriverWait Espera { get; set; }

        public Esperas(IWebDriver driver)
        {
            Espera = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        }

        public void EsperaElementoSerClicavel(IWebElement elemento)
        {
            Espera.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(elemento));

        }

    }
}
