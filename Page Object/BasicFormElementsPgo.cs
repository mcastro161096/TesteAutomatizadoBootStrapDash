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

        #endregion

        public BasicFormElementsPgo(IWebDriver driver)
        {
            CampoEmail = driver.FindElement(By.Id("input1"));
            CampoPassword = driver.FindElement(By.Id("input2"));
            BotaoSubmit = driver.FindElement(By.CssSelector(" div:nth-child(1)> form> form > .btn-success"));
            BotaoCancel = driver.FindElement(By.CssSelector(" div:nth-child(1)> form> form > .btn-light"));

        }

        

    }
}
