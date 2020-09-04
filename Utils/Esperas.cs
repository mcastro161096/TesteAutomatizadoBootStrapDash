using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteAutomatizadoBootStrapDash.Utils
{
    public class Esperas
    {
        public WebDriverWait Espera { get; set; }

    public Esperas(IWebDriver driver)
        {
            Espera = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        }

        public void EsperaElementoVisivel(IWebElement elemento)
        {
            //Espera.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(elemento.Text)));
            Espera.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.PresenceOfAllElementsLocatedBy((By)elemento));


        }

    }
}
