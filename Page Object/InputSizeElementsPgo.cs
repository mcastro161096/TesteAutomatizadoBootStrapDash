using OpenQA.Selenium;

namespace TesteAutomatizadoBootStrapDash.Page_Object
{
    class InputSizeElementsPgo
    {
        public IWebElement TituloCard { get; set; }
        public IWebElement DescricaoCard { get; set; }
        public IWebElement LabelLargeInput { get; set; }
        public IWebElement CampoLargeInput { get; set; }
        public IWebElement LabelDefaultInput { get; set; }
        public IWebElement CampoDefaultInput { get; set; }
        public IWebElement LabelSmallInput { get; set; }
        public IWebElement CampoSmallInput { get; set; }
        public IWebElement SubTituloCard { get; set; }
        public IWebElement ComboSmallInput { get; set; }
        public IWebElement ComboDefaultInput { get; set; }
        public IWebElement ComboLargeInput { get; set; }
        public IWebElement OptionSmallInput { get; set; }
        public IWebElement OptionDefaultInput { get; set; }
        public IWebElement OptionLargeInput { get; set; }


        public InputSizeElementsPgo(IWebDriver driver)
        {



            TituloCard = driver.FindElement(By.CssSelector("div.col-md-7.grid-margin.stretch-card > div > div:nth-child(1) > h4"));

            DescricaoCard = driver.FindElement(By.CssSelector("div.col-md-7.grid-margin.stretch-card > div > div:nth-child(1) > p"));

            LabelLargeInput = driver.FindElement(By.Id("__BVID__141__BV_label_"));

            CampoLargeInput = driver.FindElement(By.CssSelector("#__BVID__141  input"));

            LabelDefaultInput = driver.FindElement(By.Id("__BVID__143__BV_label_"));

            CampoDefaultInput = driver.FindElement(By.CssSelector("#__BVID__143 input"));

            LabelSmallInput = driver.FindElement(By.Id("__BVID__145__BV_label_"));

            CampoSmallInput = driver.FindElement(By.CssSelector("#__BVID__145 input"));

            SubTituloCard = driver.FindElement(By.CssSelector("div:nth-child(2) > h4"));

            ComboSmallInput = driver.FindElement(By.Id("__BVID__148"));

            OptionSmallInput = driver.FindElement(By.CssSelector("#__BVID__148 option[value='a']"));

            ComboDefaultInput = driver.FindElement(By.Id("__BVID__150"));

            OptionDefaultInput = driver.FindElement(By.CssSelector("#__BVID__150 option[value='b']"));

            ComboLargeInput = driver.FindElement(By.Id("__BVID__152"));

            OptionLargeInput = driver.FindElement(By.CssSelector("#__BVID__152 option[value='[object Object]']"));


        }
    }






}
