using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using Lens_Demo.Utility;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using OpenQA.Selenium.Interactions;

namespace Lens_Demo.POM
{
    class Portfolio
    {
        public Portfolio(IWebDriver webDriver)
        {
            Environmentev.webDriver = webDriver;
        }
        public By addPortfolio = By.XPath("//a[contains(text(), 'Add New Portfolio')]");
        public By ManagePortfolio = By.XPath("//a[@href ='#/entity/portfolios/list']");
        public By name = By.Id("name");
        public By client = By.Id("client");
        public By Address1 = By.Name("address_1");
        public By Address2 = By.Name("address_2");
        public By Country = By.Id("country");
        public By State = By.Id("state_region");
        public By City = By.Id("city");
        public By PostalCode = By.Id("postal_code");
        public By latitude = By.Id("latitude");
        public By longitude = By.Id("longitude");
        public By timezone = By.Id("time_zone");
        public By seller = By.Id("billing_biller_name");
        public By buyer = By.Id("billing_name");
        public By invoicedays = By.Id("billing_invoice_term_days");
        public By address_11 = By.Id("billing_street_1");
        public By address_12 = By.Id("billing_street_2");
        public By BScountry = By.Id("billing_country");
        public By BSstate = By.Id("billing_state_region");
        public By BScity = By.Id("billing_city");
        public By BSPostal = By.Id("billing_postal_code");
        public By Createclick = By.XPath("//button[contains(text(), 'CREATE')]");

        public By portfolioname = By.XPath("//*[@id='1655824313421-body-grid-container']/div[1]/div/div/div/div/div/div[2]/div[2]/div[3]/div/input");
        public By OKbutton = By.XPath("//button[contains(text() , 'OK')]");

        public void portfolioclick()
        {
            //Environmentev.webDriver.FindElement(By.XPath("//*[@id='side-menu']/li[3]/a/span")).Click();
            //Environmentev.webDriver.FindElement(addPortfolio).Click();
            Environmentev.webDriver.Navigate().GoToUrl("https://lens-qa-hcl.radiangen.com/#/entity/portfolios/add");
        }   
        public void Pfnameentry(string Name)
        {
            Environmentev.webDriver.FindElement(name).SendKeys(Name);
        }
        public void PfcLiententry(string Client)
        {
            Environmentev.webDriver.FindElement(client).Click();
            var comboBox = Environmentev.webDriver.FindElement(client);
            Thread.Sleep(2000);
            new SelectElement(comboBox).SelectByText(Client);
        }
        public void Pfaddress_1entry(string Ad1)
        {
            Environmentev.webDriver.FindElement(Address1).SendKeys(Ad1);
        }
        public void Pfaddress_2entry(string Ad2)
        {
            Environmentev.webDriver.FindElement(Address2).SendKeys(Ad2);
        }
        public void PfCountryselect(string country)
        {
            Environmentev.webDriver.FindElement(Country).Click();
            var comboBox = Environmentev.webDriver.FindElement(Country);
            Thread.Sleep(2000);
            new SelectElement(comboBox).SelectByText(country);
        }
        public void PfStateselect(string state)
        {
            Environmentev.webDriver.FindElement(State).Click();
            var comboBox = Environmentev.webDriver.FindElement(State);
            Thread.Sleep(2000);
            new SelectElement(comboBox).SelectByText(state);
        }
        public void Pfcityentry(string cityent)
        {
            Environmentev.webDriver.FindElement(City).SendKeys(cityent);
        }
        public void PfPostalentry(int postalent)
        {

            Environmentev.webDriver.FindElement(PostalCode).SendKeys(Convert.ToString(postalent));

        }
        public void latitudeent(int lat)
        {
            Environmentev.webDriver.FindElement(latitude).SendKeys(Convert.ToString(lat));
        }
        public void longitudeent(int lon)
        {
            Environmentev.webDriver.FindElement(longitude).SendKeys(Convert.ToString(lon));
        }
        public void timezoneent(string time)
        {
            Environmentev.webDriver.FindElement(timezone).Click();
            var comboBox = Environmentev.webDriver.FindElement(timezone);
            Thread.Sleep(2000);
            new SelectElement(comboBox).SelectByText(time);
        }

        public void clickCreate()
        {
            Environmentev.webDriver.FindElement(Createclick).Click();
            Thread.Sleep(2000);
            Actions action = new Actions(Environmentev.webDriver);
            action.SendKeys(OpenQA.Selenium.Keys.Escape);

        }

        public void Portfolioboxentry(string portfolio1)
        {
            Environmentev.webDriver.FindElement(portfolioname).SendKeys(portfolio1);
        }
        public bool portfolioexist(string portfolioname)
        {

            return Environmentev.webDriver.FindElement(By.XPath("//div[contains(text(), '" + portfolioname + "')]")).Displayed;
        }
        public void clickokbutton()
        {
            Environmentev.webDriver.FindElement(OKbutton).Click();
        }
        public void entrycheck()
        {
            var text = Environmentev.webDriver.FindElement(By.XPath("//*[@id='1655881067768-0-uiGrid-0038-cell']")).Text;
        }
    }

}
