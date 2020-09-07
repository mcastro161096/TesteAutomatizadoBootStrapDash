using NUnit.Framework;
using System;
using TesteAutomatizadoBootStrapDash.Page_Object;
using TesteAutomatizadoBootStrapDash.Utils;

namespace TesteAutomatizadoBootStrapDash.Input_Size
{
    [TestFixture]
    public class TestInsereEVerificaTextoNosInputs : BaseTest
    {
        [Test]
        public void InsereEVerificaTextoNosInputs()
        {
            AbreUrl("https://www.bootstrapdash.com/demo/star-admin-pro-vue/demo_1/#/basicFormElements/");
            InputSizeElementsPgo pageObject = new InputSizeElementsPgo(driver);

            Esperas espera = new Esperas(driver);
                espera.EsperaElementoSerClicavel(pageObject.CampoSmallInput);

                    DadosParaInputs dados = new DadosParaInputs();

                        pageObject.CampoLargeInput.SendKeys(dados.Email);

                        pageObject.CampoDefaultInput.SendKeys(dados.Email);

                        pageObject.CampoSmallInput.SendKeys(dados.Email);

                        pageObject.ComboSmallInput.Click();
                            pageObject.OptionSmallInput.Click();

                        pageObject.ComboDefaultInput.Click();
                            pageObject.OptionDefaultInput.Click();

                        pageObject.CampoLargeInput.Click();
                            pageObject.OptionLargeInput.Click();

            Assert.AreEqual(dados.Email, BuscaValorDoElementoParaInputs(driver, pageObject.CampoLargeInput));

            Assert.AreEqual(dados.Email, BuscaValorDoElementoParaInputs(driver, pageObject.CampoDefaultInput));

            Assert.AreEqual(dados.Email, BuscaValorDoElementoParaInputs(driver, pageObject.CampoSmallInput));

            Assert.AreEqual("This is First option", BuscaValorDoElementoParaDropDowns(driver, pageObject.ComboSmallInput));

            Assert.AreEqual("Selected Option", BuscaValorDoElementoParaDropDowns(driver, pageObject.ComboDefaultInput));

            Assert.AreEqual("This is an option with object value", BuscaValorDoElementoParaDropDowns(driver, pageObject.ComboLargeInput));



        }
    }
}
