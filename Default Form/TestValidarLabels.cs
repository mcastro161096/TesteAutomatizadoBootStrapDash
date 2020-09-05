using System;
using NUnit.Framework;
using TesteAutomatizadoBootStrapDash.Page_Object;
using TesteAutomatizadoBootStrapDash.Utils;

namespace TesteAutomatizadoBootStrapDash.Default_Form
{
    [TestFixture]
    public class TestValidarLabels : BaseTest
    {
        [Test]
        public void ValidarLabels()
        {
            AbreUrl("https://www.bootstrapdash.com/demo/star-admin-pro-vue/demo_1/#/basicFormElements/");
            BasicFormElementsPgo pageObject = new BasicFormElementsPgo(driver);

                Esperas espera = new Esperas(driver);
                espera.EsperaElementoSerClicavel(pageObject.CampoEmail);

                    Assert.AreEqual("Default Form", pageObject.TituloCard.Text);

                    Assert.AreEqual("Basic form layout", pageObject.DescricaoCard.Text);

                    Assert.AreEqual("Email", pageObject.LabelEmail.Text);

                    Assert.AreEqual("Password", pageObject.LabelPassword.Text);


        }
    }
}
