using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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
        #endregion

        public BasicFormElementsPgo(IWebDriver driver)
        {
            CampoEmail = driver.FindElement(By.CssSelector("#input1"));
            CampoPassword = driver.FindElement(By.CssSelector("#input2"));
        }

        
    }
}
