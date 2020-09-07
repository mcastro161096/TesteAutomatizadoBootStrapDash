using NUnit.Framework;
using TesteAutomatizadoBootStrapDash.Page_Object;
using TesteAutomatizadoBootStrapDash.Utils;

namespace TesteAutomatizadoBootStrapDash.Basic_Input_Groups
{
    [TestFixture]
    public class TestVerificarCamposHabilitados : BaseTest
    {
        [Test]
        public void VerificarCamposHabilitados()
        {
            AbreUrl("https://www.bootstrapdash.com/demo/star-admin-pro-vue/demo_1/#/basicFormElements/");
            BasicInputGroupsElementsPgo pageObject = new BasicInputGroupsElementsPgo(driver);

            Esperas espera = new Esperas(driver);
            espera.EsperaElementoSerClicavel(pageObject.Campo1);

            Assert.AreEqual(true, pageObject.Campo1.Enabled);

            Assert.AreEqual(true, pageObject.Campo2.Enabled);

            Assert.AreEqual(true, pageObject.Campo3.Enabled);

            Assert.AreEqual(true, pageObject.Campo4.Enabled);


        }
    }
}
