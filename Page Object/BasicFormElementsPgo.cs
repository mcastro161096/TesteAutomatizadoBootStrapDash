using OpenQA.Selenium;

namespace TesteAutomatizadoBootStrapDash.Page_Object
{
    class BasicFormElementsPgo
    {
        #region Basic Form

        public IWebElement TituloCard { get; set; }

        public IWebElement DescricaoCard { get; set; }

        public IWebElement LabelName { get; set; }

        public IWebElement CampoName { get; set; }

        public IWebElement LabelEmail { get; set; }

        public IWebElement CampoEmail { get; set; }

        public IWebElement LabelPassword { get; set; }

        public IWebElement CampoPassword { get; set; }

        public IWebElement LabelUpload { get; set; }

        public IWebElement CampoUpload { get; set; }

        public IWebElement LabelCity { get; set; }

        public IWebElement CampoCity { get; set; }

        public IWebElement LabelMessage { get; set; }

        public IWebElement CampoMessage { get; set; }

        public IWebElement BotaoSubmit { get; set; }

        public IWebElement BotaoCancel { get; set; }

        #endregion

        public BasicFormElementsPgo(IWebDriver driver)
        {

            TituloCard = driver.FindElement(By.CssSelector(" div.col-md-6.grid-margin.stretch-card > div > div > h4"));

            DescricaoCard = driver.FindElement(By.CssSelector(" div.col-md-6.grid-margin.stretch-card > div > div > p"));

            LabelName = driver.FindElement(By.CssSelector("[for=input5]"));

            CampoName = driver.FindElement(By.Id("input5"));

            LabelEmail = driver.FindElement(By.CssSelector("[for=input6]"));

            CampoEmail = driver.FindElement(By.Id("input6"));

            LabelPassword = driver.FindElement(By.CssSelector("[for=input7]"));

            CampoPassword = driver.FindElement(By.Id("input7"));

            LabelUpload = driver.FindElement(By.CssSelector("[for=input8]"));

            CampoUpload = driver.FindElement(By.Id("inpu8"));

            LabelCity = driver.FindElement(By.CssSelector("[for=input9]"));

            CampoCity = driver.FindElement(By.Id("input9"));

            LabelMessage = driver.FindElement(By.CssSelector("[for=input10]"));

            CampoMessage = driver.FindElement(By.Id("input10"));

            BotaoSubmit = driver.FindElement(By.CssSelector(" div.col-md-6.grid-margin.stretch-card > div > div > form > button.btn.mr-2.btn-success"));

            BotaoCancel = driver.FindElement(By.CssSelector(" div.col-md-6.grid-margin.stretch-card > div > div > form > button.btn-light"));
        }
    }
}
