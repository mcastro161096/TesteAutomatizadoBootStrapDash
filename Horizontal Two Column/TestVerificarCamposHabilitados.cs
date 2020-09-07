using System;
using NUnit.Framework;
using TesteAutomatizadoBootStrapDash.Page_Object;
using TesteAutomatizadoBootStrapDash.Utils;

namespace TesteAutomatizadoBootStrapDash.Horizontal_Two_Column
{
    [TestFixture]
    public class TestVerificarCamposHabilitados : BaseTest
    {
        [Test]
        public void VerificarCamposHabilitados()
        {

             AbreUrl("https://www.bootstrapdash.com/demo/star-admin-pro-vue/demo_1/#/basicFormElements/");
                HorizontalTwoColumnElementsPgo pageObject = new HorizontalTwoColumnElementsPgo(driver);

                Esperas espera = new Esperas(driver);
                    espera.EsperaElementoSerClicavel(pageObject.CampoFirstName);

            Assert.AreEqual(true, pageObject.CampoFirstName.Enabled);

            Assert.AreEqual(true, pageObject.CampoLastName.Enabled);

            Assert.AreEqual(true, pageObject.ComboGender.Enabled);

            Assert.AreEqual(true, pageObject.ComboCategory.Enabled);

            Assert.AreEqual(true, pageObject.CampoAddress1.Enabled);

            Assert.AreEqual(true, pageObject.CampoAddress2.Enabled);

            Assert.AreEqual(true, pageObject.CampoCity.Enabled);

            Assert.AreEqual(true, pageObject.CampoDateOfBirth.Enabled);

            Assert.AreEqual(true, pageObject.RadioMembership.Enabled);

            Assert.AreEqual(true, pageObject.CampoState.Enabled);

            Assert.AreEqual(true, pageObject.CampoPincode.Enabled);

            Assert.AreEqual(true, pageObject.ComboCountry.Enabled);
        }
    }
}
