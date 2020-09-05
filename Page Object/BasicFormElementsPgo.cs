using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteAutomatizadoBootStrapDash.Page_Object
{
    public class BasicFormElementsPgo
    {


        #region Default Form
        public IWebElement CampoEmail { get; set; }

        public IWebElement CampoPassword { get; set; }

        public IWebElement BotaoSubmit { get; set; }

        public IWebElement BotaoCancel { get; set; }

        public IWebElement TituloCard { get; set; }

        public IWebElement DescricaoCard { get; set; }

        public IWebElement LabelEmail { get; set; }

        public IWebElement LabelPassword { get; set; }

        #endregion

        public BasicFormElementsPgo(IWebDriver driver)
        {
            CampoEmail = driver.FindElement(By.Id("input1")); 

            CampoPassword = driver.FindElement(By.Id("input2"));

            BotaoSubmit = driver.FindElement(By.CssSelector(" div:nth-child(1)> form> form > .btn-success"));

            BotaoCancel = driver.FindElement(By.CssSelector(" div:nth-child(1)> form> form > .btn-light"));

            TituloCard = driver.FindElement(By.CssSelector(" div.col-md-6.d-flex.align-items-stretch.grid-margin > div > div:nth-child(1) > div > div> h4"));

            DescricaoCard = driver.FindElement(By.CssSelector(" div.col-md-6.d-flex.align-items-stretch.grid-margin > div > div:nth-child(1) > div > div> p"));

            LabelEmail = driver.FindElement(By.CssSelector("[for='input1']"));

            LabelPassword = driver.FindElement(By.CssSelector("[for='input2']"));
        }

        

    }
}
