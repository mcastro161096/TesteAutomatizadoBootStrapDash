using NUnit.Framework;
using OpenQA.Selenium;
using TesteAutomatizadoBootStrapDash.Page_Object;
using TesteAutomatizadoBootStrapDash.Utils;

namespace TesteAutomatizadoBootStrapDash.Date_Picker_Inline
{
    [TestFixture]
    public class TestSelecionar4Maio2022 : BaseTest
    {
        [Test]
        public void Selecionar4Maio2022()
        {
            AbreUrl("https://www.bootstrapdash.com/demo/star-admin-pro-vue/demo_1/#/advancedFormElements/");
            DatePickerInlineElementsPgo pageObject = new DatePickerInlineElementsPgo(driver);

            Esperas espera = new Esperas(driver);
            espera.EsperaElementoSerClicavel(pageObject.CampoSelectDate);

            pageObject.CampoSelectDate.Click();

            pageObject.CampoMesAno.Click();

            pageObject.CampoAno.Click();

            pageObject.Ano2022.Click();


            try
            {

                pageObject.MesMaio.Click();

                pageObject.Dia4.Click();

            }
            catch (StaleElementReferenceException ex)
            {



                IWebElement MesMaio = driver.FindElement(By.CssSelector(" div.col-md-12.grid-margin.stretch-card > div > div > div > div:nth-child(3) > span:nth-child(6)"));

                MesMaio.Click();

                IWebElement Dia4 = driver.FindElement(By.CssSelector("  div.col-md-12.grid-margin.stretch-card > div > div > div > div:nth-child(2) > div > span:nth-child(11)"));

                Dia4.Click();
            }

            Assert.AreEqual("04 May 2022", BuscaValorDoElementoQuerySelector(driver, "div > div > div > div:nth-child(1) > input[type=text]"));

        }
    }
}
