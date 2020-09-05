using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteAutomatizadoBootStrapDash.Page_Object
{
    public class BasicInputGroupsElementsPgo
    {

        public IWebElement TituloCard { get; set; }
        public IWebElement DescricaoCard { get; set; }
        public IWebElement Campo1 { get; set; }
        public IWebElement Campo2 { get; set; }
        public IWebElement Campo3 { get; set; }
        public IWebElement Campo4 { get; set; }

        public BasicInputGroupsElementsPgo(IWebDriver driver)
        {
            TituloCard = driver.FindElement(By.CssSelector("div.col-md-5.d-flex.align-items-stretch > div > div:nth-child(1) > div > div > h4"));
            DescricaoCard = driver.FindElement(By.CssSelector("div.col-md-5.d-flex.align-items-stretch > div > div:nth-child(1) > div > div > p"));
            Campo1 = driver.FindElement(By.Id("__BVID__126"));
            Campo2 = driver.FindElement(By.Id("__BVID__128"));
            Campo3 = driver.FindElement(By.Id("__BVID__130"));
            Campo4 = driver.FindElement(By.CssSelector("#__BVID__131 > div > div > div.input-group-prepend > div:nth-child(2)"));
        }

    }
}
