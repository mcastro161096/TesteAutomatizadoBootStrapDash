﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteAutomatizadoBootStrapDash
{
    public class BaseTest
    {
        public IWebDriver driver { get; set; }


        [TearDown]
        public void FecharNavegador()
        {
            driver.Close();
            driver.Quit();
            driver = null;
        }
        [SetUp]
        public void AbrirNavegador()
        {
            driver = new ChromeDriver();
            //ChromeOptions options = new ChromeOptions();
            //options.AddArgument("headless")hghjghjg;
            //driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
        }
        public void AbreUrl(string link)
        {
            driver.Navigate().GoToUrl(link);

        }
    }
}
