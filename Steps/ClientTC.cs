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



namespace Lens_Demo.Steps
{


    [Binding]
    public class ClientTC
    {

        

        LoginPage loginpage = new LoginPage(Environmentev.webDriver);
        HomePage homep = new HomePage(Environmentev.webDriver);
        ClientPage clientp = new ClientPage(Environmentev.webDriver);

        [Given(@"the environment")]
        public void GivenTheEnvironment()
        {
            Environmentev.LaunchWebdriver();


        }

        [Given(@"Enter the userName")]
        public void GivenEnterTheUserName()
        {
            Environmentev.waitfor100second(loginpage.LoginInput);
            loginpage.setUserName(Hooks.config.Stage.HCL_QA.UserName);
        }

        [Given(@"Enter Password")]
        public void GivenEnterPassword()
        {
            loginpage.setPassword(Hooks.config.Stage.HCL_QA.Password);
        }

        [Then(@"Click on Login")]
        public void ThenClickOnLogin()
        {
            loginpage.Loginbutton();
        }

        [Then(@"validate the login condition")]
        public void ThenValidateTheLoginCondition()
        {
            Environmentev.waitfor10second(homep.homepage);
            homep.elementdisplayed();
        }

        [Then(@"Click on Add Client and Add a new client")]
        public void ThenClickOnAddClientAndAddANewClient()
        {
            homep.Clientclick();
            Thread.Sleep(2000);
            
        }

        [Then(@"Fill the client Form ""(.*)"",""(.*)"", ""(.*)"",""(.*)"",""(.*)"",""(.*)"",""(.*)"",""(.*)"",""(.*)""")]
        public void ThenFillTheClientForm(string Name, string Account, string Comment, string Address1, string Address2, string Country, string State, string City, int Postalcode)
        {
            Environmentev.waitfor5second(clientp.name);
            clientp.nameentry(Name);
            clientp.SelectAccount(Account);
            clientp.commentsentry(Comment);
            clientp.Address1entry(Address1);
            clientp.Address2entry(Address2);
            clientp.Countryselect(Country);
            clientp.Stateselect(State);
            clientp.cityentry(City);
            clientp.Postalentry(Postalcode);
            clientp.clickCreate();

            
        }

        [Given(@"Click on Manage Client")]
        public void GivenClickOnManageClient()
        {
            Thread.Sleep(2000);
            homep.ClientclickList();
        }
        /*
        [Given(@"Click on the Newly Created Client ""(.*)""")]
        public void GivenClickOnTheNewlyCreatedClient(string Name)
        {
            clientp.clientexist(Name);
        }*/



        [Given(@"Validate the Client information""(.*)""")]
        public void GivenValidateTheClientInformation(string Name)
        {
            clientp.clientexist(Name);
        }


    }
}