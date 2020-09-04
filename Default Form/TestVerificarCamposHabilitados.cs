using NUnit.Framework;
using TesteAutomatizadoBootStrapDash.Page_Object;
using TesteAutomatizadoBootStrapDash.Utils;
using Assert = NUnit.Framework.Assert;

namespace TesteAutomatizadoBootStrapDash
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

            Assert.AreEqual(pageObject.CampoEmail.Enabled, true);

            Assert.AreEqual(pageObject.CampoPassword.Enabled, true);


        }
    }
}
