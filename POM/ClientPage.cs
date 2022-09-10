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
    class ClientPage
    {
        public ClientPage(IWebDriver webDriver)
        {
            Environmentev.webDriver = webDriver;
        }

        public By name = By.Id("name");
        public By AccountExec = By.Id("account_executive");
        public By Comments = By.Id("comments");
        public By Address1 = By.Name("address_1");
        public By Address2 = By.Name("address_2");
        public By Country = By.Id("country");
        public By State = By.Id("state_region");
        public By City = By.Id("city");
        public By  PostalCode = By.Id("postal_code");
        public By Createclick = By.XPath("//button[contains(text(), 'CREATE')]");

        public By clientclick = By.XPath("//td[contains(text(),'Wiser Capital')]");
        public By filter = By.XPath("//a[@class='btn btn-default filter wish-button filter-red']");
        public By clienttext = By.Id("filter-basic");
        

        public void nameentry(string nameent)
        {
            Environmentev.webDriver.FindElement(name).SendKeys(nameent);
        }
        public void SelectAccount(string Accnt)
        {
            Environmentev.webDriver.FindElement(AccountExec).Click();
            var comboBox = Environmentev.webDriver.FindElement(AccountExec);
            Thread.Sleep(3000);
            new SelectElement(comboBox).SelectByText(Accnt);
            
        }

        public void commentsentry(string comment)
        {
            Environmentev.webDriver.FindElement(Comments).SendKeys(comment);
        }

        public void Address1entry(string adress1ent)
        {
            Environmentev.webDriver.FindElement(Address1).SendKeys(adress1ent);
        }
        public void Address2entry(string adress2ent)
        {
            Environmentev.webDriver.FindElement(Address2).SendKeys(adress2ent);
        }
        public void Countryselect(string country)
        {
            Environmentev.webDriver.FindElement(Country).Click();
            var comboBox = Environmentev.webDriver.FindElement(Country);
            Thread.Sleep(2000);
            new SelectElement(comboBox).SelectByText(country);
        }
        public void Stateselect(string state)
        {
            Environmentev.webDriver.FindElement(State).Click();
            var comboBox = Environmentev.webDriver.FindElement(State);
            Thread.Sleep(2000);
            new SelectElement(comboBox).SelectByText(state);
        }
        public void cityentry(string cityent)
        {
            Environmentev.webDriver.FindElement(City).SendKeys(cityent);
        }
        public void Postalentry(int postalent)
        {
            
            Environmentev.webDriver.FindElement(PostalCode).SendKeys(Convert.ToString(postalent));
            
        }
        public void clickCreate()
        {
            Environmentev.webDriver.FindElement(Createclick).Click();
        }
        public bool clientexist(string clientname)
        {

            Thread.Sleep(3000);
            Environmentev.webDriver.FindElement(By.XPath("//*[@id='page-wrapper']/div/div[1]/div[3]/div/span/a")).Click();
            Environmentev.webDriver.FindElement(clienttext).SendKeys(clientname);
            Thread.Sleep(2000);
            return Environmentev.webDriver.FindElement(By.XPath("//td[contains(text(), '" + clientname + "')]")).Displayed;
            
        }
        
    }
}
