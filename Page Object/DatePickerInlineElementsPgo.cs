using OpenQA.Selenium;

namespace TesteAutomatizadoBootStrapDash.Page_Object
{
    public class DatePickerInlineElementsPgo
    {
        public IWebElement CampoSelectDate { get; set; }

        public IWebElement CampoMesAno { get; set; }

        public IWebElement CampoAno { get; set; }

        public IWebElement SetaPrev { get; set; }

        public IWebElement Ano2010 { get; set; }

        public IWebElement MesAgosto { get; set; }

        public IWebElement Dia30 { get; set; }

        public IWebElement Ano2022 { get; set; }

        public IWebElement MesMaio { get; set; }

        public IWebElement Dia4 { get; set; }


        public DatePickerInlineElementsPgo(IWebDriver driver)
        {
            CampoSelectDate = driver.FindElement(By.CssSelector("div > div > div > div:nth-child(1) > input[type=text]"));

            CampoMesAno = driver.FindElement(By.CssSelector(" div.col-md-12.grid-margin.stretch-card > div > div > div.vdp-datepicker div> header > span:nth-child(2).day__month_btn.up"));

            CampoAno = driver.FindElement(By.CssSelector(" div.col-md-12.grid-margin.stretch-card > div > div > div.vdp-datepicker div> header > span:nth-child(2).month__year_btn.up"));

            SetaPrev = driver.FindElement(By.CssSelector(" div.col-md-12.grid-margin.stretch-card > div > div > div > div:nth-child(4) > header > span.prev"));

            Ano2010 = driver.FindElement(By.CssSelector(" div > div.col-md-12.grid-margin.stretch-card > div > div > div > div:nth-child(4) > span:nth-child(2)"));

            MesAgosto = driver.FindElement(By.CssSelector("div.col-md-12.grid-margin.stretch-card > div > div > div > div:nth-child(3) > span:nth-child(9)"));

            Dia30 = driver.FindElement(By.CssSelector(" div.col-md-12.grid-margin.stretch-card > div > div > div > div:nth-child(2) > div > span:nth-child(37)"));

            Ano2022 = driver.FindElement(By.CssSelector(" div.col-md-12.grid-margin.stretch-card > div > div > div > div:nth-child(4) > span:nth-child(4)"));

            MesMaio = driver.FindElement(By.CssSelector(" div.col-md-12.grid-margin.stretch-card > div > div > div > div:nth-child(3) > span:nth-child(6)"));

            Dia4 = driver.FindElement(By.CssSelector("  div.col-md-12.grid-margin.stretch-card > div > div > div > div:nth-child(2) > div > span:nth-child(11)"));

        }

    }
}
