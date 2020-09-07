using NUnit.Framework;
using System;
using TesteAutomatizadoBootStrapDash.Page_Object;
using TesteAutomatizadoBootStrapDash.Utils;

namespace TesteAutomatizadoBootStrapDash.Basic_Input_Groups
{
    [TestFixture]
    public class TestInsereEVerificaTextoNosInputs : BaseTest
    {
        [Test]
        public void InsereEVerificaTextoNosInputs()
        {
            AbreUrl("https://www.bootstrapdash.com/demo/star-admin-pro-vue/demo_1/#/basicFormElements/");
            BasicInputGroupsElementsPgo pageObject = new BasicInputGroupsElementsPgo(driver);

            Esperas espera = new Esperas(driver);
                espera.EsperaElementoSerClicavel(pageObject.Campo1);

                    DadosParaInputs dados = new DadosParaInputs();

                    pageObject.Campo1.SendKeys(dados.UserName);

                    pageObject.Campo2.SendKeys(dados.UserName);

                    pageObject.Campo3.SendKeys(dados.Valor.ToString());


            Assert.AreEqual(dados.UserName, BuscaValorDoElementoParaInputs(driver, pageObject.Campo1));

            Assert.AreEqual(dados.UserName, BuscaValorDoElementoParaInputs(driver, pageObject.Campo2));

            Assert.AreEqual(dados.Valor.ToString(), BuscaValorDoElementoParaInputs(driver, pageObject.Campo3));

            Assert.AreEqual("00.0", pageObject.Campo4.Text);




        }
    }
}
