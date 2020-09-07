using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteAutomatizadoBootStrapDash.Page_Object
{
    public class HorizontalTwoColumnElementsPgo
    {
       

        public IWebElement CampoFirstName { get; set; }

        public IWebElement CampoLastName { get; set; }

        public IWebElement ComboGender { get; set; }

        public IWebElement ComboCategory { get; set; }

        public IWebElement CampoAddress1 { get; set; }

        public IWebElement CampoAddress2 { get; set; }

        public IWebElement CampoCity { get; set; }

        public IWebElement CampoDateOfBirth { get; set; }

        public IWebElement RadioMembership { get; set; }
    
        public IWebElement LabelMembership { get; set; }

        public IWebElement CampoState { get; set; }

        public IWebElement CampoPincode { get; set; }

        public IWebElement ComboCountry { get; set; }

        public IWebElement OptionGender { get; set; }

        public IWebElement OptionCategory { get; set; }

        public IWebElement OptionCountry { get; set; }

       


        public HorizontalTwoColumnElementsPgo(IWebDriver driver)
        {
            CampoFirstName = driver.FindElement(By.Id("input14"));

            CampoLastName = driver.FindElement(By.Id("__BVID__156"));

            ComboGender = driver.FindElement(By.Id("__BVID__158"));

            ComboCategory = driver.FindElement(By.Id("__BVID__162"));

            CampoAddress1 = driver.FindElement(By.Id("input15"));

            CampoAddress2 = driver.FindElement(By.Id("input17"));

            CampoCity = driver.FindElement(By.Id("input19"));

            CampoDateOfBirth = driver.FindElement(By.Id("__BVID__160"));

            RadioMembership = driver.FindElement(By.CssSelector("#radios2 > div:nth-child(2) > input"));
           
            LabelMembership = driver.FindElement(By.CssSelector("[for='__BVID__166']"));

            CampoState = driver.FindElement(By.Id("input16"));

            CampoPincode = driver.FindElement(By.Id("input18"));

            ComboCountry = driver.FindElement(By.Id("__BVID__178"));

            OptionGender = driver.FindElement(By.CssSelector("#__BVID__158 > option:nth-child(1)"));

            OptionCategory = driver.FindElement(By.CssSelector("#__BVID__162 > option:nth-child(1)"));

            OptionCountry = driver.FindElement(By.CssSelector("#__BVID__178 > option:nth-child(5)"));
        }



    }
}
