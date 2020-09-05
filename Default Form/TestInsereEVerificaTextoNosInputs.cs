using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteAutomatizadoBootStrapDash.Page_Object;
using TesteAutomatizadoBootStrapDash.Utils;

namespace TesteAutomatizadoBootStrapDash.Default_Form
{
    [TestFixture]
    public class TestInsereEVerificaTextoNosInputs : BaseTest
    {
        [Test]
        public void InsereEVerificaTextoNosInputs()
        {
            AbreUrl("https://www.bootstrapdash.com/demo/star-admin-pro-vue/demo_1/#/basicFormElements/");
            DefaultFormElementsPgo pageObject = new DefaultFormElementsPgo(driver);

            Esperas espera = new Esperas(driver);
             espera.EsperaElementoSerClicavel(pageObject.CampoEmail);

            DadosParaInputs dados = new DadosParaInputs();

                pageObject.CampoEmail.SendKeys(dados.Email);
                pageObject.CampoPassword.SendKeys(dados.Password);

                    var valorAtualEmail = BuscaValorDoElemento(driver, pageObject.CampoEmail);
                    var valorAtualPassword = BuscaValorDoElemento(driver, pageObject.CampoPassword);

                        Assert.AreEqual(dados.Email, valorAtualEmail);
                        Assert.AreEqual(dados.Password, valorAtualPassword);

            

        }

    }
}
