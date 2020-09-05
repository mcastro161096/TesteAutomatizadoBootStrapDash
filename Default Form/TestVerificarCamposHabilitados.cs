using NUnit.Framework;
using TesteAutomatizadoBootStrapDash.Page_Object;
using TesteAutomatizadoBootStrapDash.Utils;
using Assert = NUnit.Framework.Assert;

namespace TesteAutomatizadoBootStrapDash.Default_Form
{
    [TestFixture]
    public class TestVerificarCamposHabilitados : BaseTest
    {

        [Test]
        public void VerificarCamposHabilitados()
        {
            AbreUrl("https://www.bootstrapdash.com/demo/star-admin-pro-vue/demo_1/#/basicFormElements/");
            DefaultFormElementsPgo pageObject = new DefaultFormElementsPgo(driver);

                Esperas espera = new Esperas(driver);
                        espera.EsperaElementoSerClicavel(pageObject.CampoEmail);

                    Assert.AreEqual(true, pageObject.CampoEmail.Enabled);

                    Assert.AreEqual(true, pageObject.CampoPassword.Enabled);

                    Assert.AreEqual(true, pageObject.BotaoSubmit.Enabled);

                    Assert.AreEqual(true, pageObject.BotaoCancel.Enabled);



        }
    }
}
