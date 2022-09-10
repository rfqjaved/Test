using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using Lens_Demo.POM;
using Lens_Demo.Hook;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;
using Lens_Demo.Utility;
using System.Threading;
using OpenQA.Selenium.Interactions;

namespace Lens_Demo.Steps
{
    [Binding]
    public sealed class Portfolio_TC
    {
       
        LoginPage loginpage = new LoginPage(Environmentev.webDriver);
        HomePage homep = new HomePage(Environmentev.webDriver);
        ClientPage clientp = new ClientPage(Environmentev.webDriver);
        Portfolio portfolio = new Portfolio(Environmentev.webDriver);

        [Given(@"Click on Add Portfolio and Add a new Portfolio")]
        public void GivenClickOnAddPortfolioAndAddANewPortfolio()
        {
            portfolio.portfolioclick();
        }

        [Given(@"Fill the form ""(.*)"",""(.*)"",""(.*)"",""(.*)"",""(.*)"",""(.*)"",""(.*)"",""(.*)"",""(.*)"",""(.*)"",""(.*)""")]
        public void GivenFillTheForm(string Name, string CLient, string Address1, string Address2, string COuntry, string State, string City, int Postalcode, Decimal Latitude, Decimal Longitude, string Timezone)
        {
            Thread.Sleep(5000);
            portfolio.Pfnameentry(Name);
            portfolio.PfcLiententry(CLient);
            portfolio.Pfaddress_1entry(Address1);
            portfolio.Pfaddress_2entry(Address2);
            portfolio.PfCountryselect(COuntry);
            portfolio.PfStateselect(State);
            portfolio.Pfcityentry(City);
            portfolio.PfPostalentry(Postalcode);
           // portfolio.latitudeent(Latitude);
            //portfolio.longitudeent(Longitude);
            //portfolio.timezoneent(Timezone);
            portfolio.clickCreate();
            
        }

       


        [Given(@"Validate the existence of portfolio ""(.*)""")]
        public void GivenValidateTheExistenceOfPortfolio(string Name)
        {
            Actions action = new Actions(Environmentev.webDriver);
            action.SendKeys(OpenQA.Selenium.Keys.Escape);
            Environmentev.webDriver.Navigate().GoToUrl("https://lens-qa-hcl.radiangen.com/#/entity/portfolios/list");
            Thread.Sleep(2000);
            portfolio.portfolioexist(Name);
            
        }
        






    }
}   
