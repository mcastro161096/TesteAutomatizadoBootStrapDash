using NUnit.Framework;
using System;
using TesteAutomatizadoBootStrapDash.Page_Object;
using TesteAutomatizadoBootStrapDash.Utils;

namespace TesteAutomatizadoBootStrapDash.Basic_Form
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

                Assert.AreEqual("Basic Form", pageObject.TituloCard.Text);

                Assert.AreEqual("Basic form elements", pageObject.DescricaoCard.Text);

                Assert.AreEqual("Name", pageObject.LabelName.Text);

                Assert.AreEqual("Email address", pageObject.LabelEmail.Text);

                Assert.AreEqual("Password", pageObject.LabelPassword.Text);

                Assert.AreEqual("Upload file", pageObject.LabelUpload.Text);

                Assert.AreEqual("City", pageObject.LabelCity.Text);

                Assert.AreEqual("Message", pageObject.LabelMessage.Text);



        }
    }
}
