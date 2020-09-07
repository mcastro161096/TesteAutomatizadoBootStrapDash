using NUnit.Framework;
using System;
using TesteAutomatizadoBootStrapDash.Page_Object;
using TesteAutomatizadoBootStrapDash.Utils;

namespace TesteAutomatizadoBootStrapDash.Input_Size
{
    [TestFixture]
    public class TestVerificarCamposHabilitados : BaseTest
    {
        [Test]
        public void VerificarCamposHabilitados()
        {
            AbreUrl("https://www.bootstrapdash.com/demo/star-admin-pro-vue/demo_1/#/basicFormElements/");
            InputSizeElementsPgo pageObject = new InputSizeElementsPgo(driver);

                Esperas espera = new Esperas(driver);
                 espera.EsperaElementoSerClicavel(pageObject.CampoSmallInput);

            Assert.AreEqual(true, pageObject.CampoLargeInput.Enabled);

            Assert.AreEqual(true, pageObject.CampoDefaultInput.Enabled);

            Assert.AreEqual(true, pageObject.CampoSmallInput.Enabled);

            Assert.AreEqual(true, pageObject.ComboSmallInput.Enabled);

            Assert.AreEqual(true, pageObject.ComboDefaultInput.Enabled);

            Assert.AreEqual(true, pageObject.ComboLargeInput.Enabled);



        }
    }
}
