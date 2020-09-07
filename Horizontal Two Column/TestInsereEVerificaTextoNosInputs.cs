using NUnit.Framework;
using TesteAutomatizadoBootStrapDash.Page_Object;
using TesteAutomatizadoBootStrapDash.Utils;

namespace TesteAutomatizadoBootStrapDash.Horizontal_Two_Column
{
    [TestFixture]
    public class TestInsereEVerificaTextoNosInputs : BaseTest
    {
        [Test]
        public void InsereEVerificaTextoNosInputs()
        {
            AbreUrl("https://www.bootstrapdash.com/demo/star-admin-pro-vue/demo_1/#/basicFormElements/");
            HorizontalTwoColumnElementsPgo pageObject = new HorizontalTwoColumnElementsPgo(driver);

            Esperas espera = new Esperas(driver);
            espera.EsperaElementoSerClicavel(pageObject.CampoFirstName);

            DadosParaInputs dados = new DadosParaInputs();

            pageObject.CampoFirstName.SendKeys(dados.Name);

            pageObject.CampoLastName.SendKeys(dados.UserName);

            pageObject.ComboGender.Click();
            pageObject.OptionGender.Click();

            pageObject.ComboCategory.Click();
            pageObject.OptionCategory.Click();

            pageObject.CampoAddress1.SendKeys(dados.Addrress1);

            pageObject.CampoAddress2.SendKeys(dados.Address2);

            pageObject.CampoCity.SendKeys(dados.City);

            pageObject.CampoDateOfBirth.SendKeys(dados.DateOfBirth.ToString());

            pageObject.LabelMembership.Click();

            pageObject.CampoState.SendKeys(dados.State);

            pageObject.CampoPincode.SendKeys(dados.Pincode);

            pageObject.ComboCountry.Click();
            pageObject.OptionCountry.Click();


            Assert.AreEqual(dados.Name, BuscaValorDoElementoParaInputs(driver, pageObject.CampoFirstName));

            Assert.AreEqual(dados.UserName, BuscaValorDoElementoParaInputs(driver, pageObject.CampoLastName));

            Assert.AreEqual("Male", BuscaValorDoElementoParaDropDowns(driver, pageObject.ComboGender));

            Assert.AreEqual("Category 1", BuscaValorDoElementoParaDropDowns(driver, pageObject.ComboCategory));

            Assert.AreEqual(dados.Addrress1, BuscaValorDoElementoParaInputs(driver, pageObject.CampoAddress1));

            Assert.AreEqual(dados.Address2, BuscaValorDoElementoParaInputs(driver, pageObject.CampoAddress2));

            Assert.AreEqual(dados.City, BuscaValorDoElementoParaInputs(driver, pageObject.CampoCity));

            Assert.AreEqual(dados.DateOfBirth.ToString(), BuscaValorDoElementoParaInputs(driver, pageObject.CampoDateOfBirth));

            Assert.AreEqual(true, pageObject.RadioMembership.Selected);

            Assert.AreEqual(dados.State, BuscaValorDoElementoParaInputs(driver, pageObject.CampoState));

            Assert.AreEqual(dados.Pincode, BuscaValorDoElementoParaInputs(driver, pageObject.CampoPincode));

            Assert.AreEqual("Britain", BuscaValorDoElementoParaDropDowns(driver, pageObject.ComboCountry));

        }
    }
}
