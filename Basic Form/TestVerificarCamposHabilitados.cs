using NUnit.Framework;
using TesteAutomatizadoBootStrapDash.Page_Object;
using TesteAutomatizadoBootStrapDash.Utils;

namespace TesteAutomatizadoBootStrapDash.Basic_Form
{
    [TestFixture]
    public class TestVerificarCamposHabilitados : BaseTest
    {
        [Test]
        public void VerificarCamposHabilitados()
        {
            AbreUrl("https://www.bootstrapdash.com/demo/star-admin-pro-vue/demo_1/#/basicFormElements/");
            BasicFormElementsPgo pageObject = new BasicFormElementsPgo(driver);

            Esperas espera = new Esperas(driver);
            espera.EsperaElementoSerClicavel(pageObject.CampoEmail);


            Assert.AreEqual(true, pageObject.CampoName.Enabled);

            Assert.AreEqual(true, pageObject.CampoEmail.Enabled);

            Assert.AreEqual(true, pageObject.CampoPassword.Enabled);

            Assert.AreEqual(true, pageObject.CampoUpload.Enabled);

            Assert.AreEqual(true, pageObject.CampoCity.Enabled);

            Assert.AreEqual(true, pageObject.CampoMessage.Enabled);



        }
    }
}
