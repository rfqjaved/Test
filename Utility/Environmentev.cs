using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using Lens_Demo.POM;
using Lens_Demo.Hook;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;
using NUnit.Framework;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support.UI;
using Lens_Demo.Utility;
using System.Runtime.CompilerServices;
using System.IO;

namespace Lens_Demo.Utility
{
    
    public class Environmentev 
    {
        public static IWebDriver? webDriver;

       

        public static void LaunchWebdriver()
        {
            try
            {
                switch (Hooks.config.Browser)
                    
                {
                    case "chrome":
                        string chromeDriverPath = System.IO.Directory.GetParent(@"../../../").FullName
            + Path.DirectorySeparatorChar + "Drivers/";
                        //string chromeDriverPath = @"C:\Users\rafique.javed\OneDrive - HCL Technologies Ltd\Desktop\";
                        ChromeOptions options = new ChromeOptions();
                        options.AddArguments(new List<string>() { "headless" });
                        
                        var chromeDriverService = ChromeDriverService.CreateDefaultService();
                        Environmentev.webDriver = new ChromeDriver(chromeDriverPath,options);
                        //Environmentev.webDriver = new ChromeDriver(@"C:\Users\rafique.javed\OneDrive - HCL Technologies Ltd\Desktop\");
                        break;

                    case "firefox":
                        Environmentev.webDriver = new FirefoxDriver(@"C:\Users\rafique.javed\source\repos\Lens_Demo\");
                        break;
                    case "IE":
                        Environmentev.webDriver = new InternetExplorerDriver(@"C:\Users\rafique.javed\source\repos\Lens_Demo\");
                        break;

                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }

            webDriver.Manage().Window.Maximize();

            if (Hooks.config.Stage.HCL_QA.RunTest == "Yes")
            {
                Environmentev.webDriver.Navigate().GoToUrl(Hooks.config.Stage.HCL_QA.URL);
            }
            else if (Hooks.config.Stage.QA.RunTest == "Yes")
            {
                Environmentev.webDriver.Navigate().GoToUrl(Hooks.config.Stage.QA.URL);
            }
            else
            {
                Environmentev.webDriver.Navigate().GoToUrl(Hooks.config.Stage.Staging.URL);
            }

        }

        public static void  waitfor100second(By item)
        {
            WebDriverWait wait = new WebDriverWait(Environmentev.webDriver, TimeSpan.FromSeconds(100000));
            wait.Until(ExpectedConditions.ElementIsVisible(item));
        }

        public static void waitfor50second(By item)
        {
            WebDriverWait wait = new WebDriverWait(Environmentev.webDriver, TimeSpan.FromSeconds(50000));
            wait.Until(ExpectedConditions.ElementIsVisible(item));
        }

        public static void waitfor10second(By item)
        {
            WebDriverWait wait = new WebDriverWait(Environmentev.webDriver, TimeSpan.FromSeconds(10000));
            wait.Until(ExpectedConditions.ElementIsVisible(item));
        }

        public static void waitfor5second(By item)
        {
            WebDriverWait wait = new WebDriverWait(Environmentev.webDriver, TimeSpan.FromSeconds(5000));
            wait.Until(ExpectedConditions.ElementIsVisible(item));
        }

    }    
}
