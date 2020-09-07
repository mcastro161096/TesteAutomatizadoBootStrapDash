using NUnit.Framework;
using OpenQA.Selenium;
using TesteAutomatizadoBootStrapDash.Page_Object;
using TesteAutomatizadoBootStrapDash.Utils;

namespace TesteAutomatizadoBootStrapDash.Date_Picker_Inline
{
    [TestFixture]
    public class TestSelecionar30Agosto2010 : BaseTest
    {
        [Test]
        public void Selecionar30Agosto2010()
        {
            AbreUrl("https://www.bootstrapdash.com/demo/star-admin-pro-vue/demo_1/#/advancedFormElements/");
            DatePickerInlineElementsPgo pageObject = new DatePickerInlineElementsPgo(driver);

            Esperas espera = new Esperas(driver);
            espera.EsperaElementoSerClicavel(pageObject.CampoSelectDate);

            pageObject.CampoSelectDate.Click();

            pageObject.CampoMesAno.Click();

            pageObject.CampoAno.Click();

            pageObject.SetaPrev.Click();

            try
            {
                pageObject.Ano2010.Click();

                pageObject.MesAgosto.Click();

                pageObject.Dia30.Click();



            }
            catch (StaleElementReferenceException ex)
            {
                IWebElement Ano2010 = driver.FindElement(By.CssSelector(" div > div.col-md-12.grid-margin.stretch-card > div > div > div > div:nth-child(4) > span:nth-child(2)"));

                Ano2010.Click();

                IWebElement MesAgosto = driver.FindElement(By.CssSelector("div.col-md-12.grid-margin.stretch-card > div > div > div > div:nth-child(3) > span:nth-child(9)"));

                MesAgosto.Click();

                IWebElement Dia30 = driver.FindElement(By.CssSelector(" div.col-md-12.grid-margin.stretch-card > div > div > div > div:nth-child(2) > div > span:nth-child(37)"));

                Dia30.Click();
            }

            Assert.AreEqual("30 Aug 2010", BuscaValorDoElementoQuerySelector(driver, "div > div > div > div:nth-child(1) > input[type=text]"));

        }
    }
}
