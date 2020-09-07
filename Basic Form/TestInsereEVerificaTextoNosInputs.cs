using NUnit.Framework;
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


            Assert.AreEqual(dados.Name, BuscaValorDoElementoParaInputs(driver, pageObject.CampoName));

            Assert.AreEqual(dados.Email, BuscaValorDoElementoParaInputs(driver, pageObject.CampoEmail));

            Assert.AreEqual(dados.Password, BuscaValorDoElementoParaInputs(driver, pageObject.CampoPassword));

            Assert.AreEqual("C:\\fakepath\\Arquivo.docx", BuscaValorDoElementoParaInputs(driver, pageObject.CampoUpload));

            Assert.AreEqual(dados.City, BuscaValorDoElementoParaInputs(driver, pageObject.CampoCity));

            Assert.AreEqual(dados.Message, BuscaValorDoElementoParaInputs(driver, pageObject.CampoMessage));



        }
    }
}
