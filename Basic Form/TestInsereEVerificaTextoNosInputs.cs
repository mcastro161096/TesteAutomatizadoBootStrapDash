using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections;
using TesteAutomatizadoBootStrapDash.Page_Object;
using TesteAutomatizadoBootStrapDash.Utils;

namespace TesteAutomatizadoBootStrapDash.Basic_Form
{
    [TestFixture]
    public class TestInsereEVerificaTextoNosInputs : BaseTest
    {
        [Test]
        public void InsereEVerificaTextoNosInputs()
        {
            AbreUrl("https://www.bootstrapdash.com/demo/star-admin-pro-vue/demo_1/#/basicFormElements/");
            BasicFormElementsPgo pageObject = new BasicFormElementsPgo(driver);

                Esperas espera = new Esperas(driver);
                espera.EsperaElementoSerClicavel(pageObject.CampoEmail);

                 DadosParaInputs dados = new DadosParaInputs();


                    pageObject.CampoName.SendKeys(dados.Name);

                    pageObject.CampoEmail.SendKeys(dados.Email);

                    pageObject.CampoPassword.SendKeys(dados.Password);

                    pageObject.CampoUpload.SendKeys(dados.Arquivo);

                    pageObject.CampoCity.SendKeys(dados.City);

                    pageObject.CampoMessage.SendKeys(dados.Message);


            Assert.AreEqual(dados.Name, BuscaValorDoElemento(driver, pageObject.CampoName));

            Assert.AreEqual(dados.Email, BuscaValorDoElemento(driver, pageObject.CampoEmail));

            Assert.AreEqual(dados.Password, BuscaValorDoElemento(driver, pageObject.CampoPassword));

            Assert.AreEqual("C:\\fakepath\\Arquivo.docx", BuscaValorDoElemento(driver, pageObject.CampoUpload));

            Assert.AreEqual(dados.City, BuscaValorDoElemento(driver, pageObject.CampoCity));

            Assert.AreEqual(dados.Message, BuscaValorDoElemento(driver, pageObject.CampoMessage));



        }
    }
}
