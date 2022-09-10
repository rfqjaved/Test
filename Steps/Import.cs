using Lens_Demo.Hook;
using Lens_Demo.POM;
using Lens_Demo.Utility;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace Lens_Demo.Steps
{
    [Binding]
    public class Import
    {
        LoginPage loginpage = new LoginPage(Environmentev.webDriver);
        HomePage homep = new HomePage(Environmentev.webDriver);
        ClientPage clientp = new ClientPage(Environmentev.webDriver);
        task Task = new task(Environmentev.webDriver);


        [Given(@"the environment1")]
        public void GivenTheEnvironment1()
        {
            Environmentev.LaunchWebdriver();


        }

        [Given(@"Enter the userName1")]
        public void GivenEnterTheUserName1()
        {
            Environmentev.waitfor100second(loginpage.LoginInput);
            loginpage.setUserName(Hooks.config.Stage.HCL_QA.UserName);
        }

        [Given(@"Enter Password1")]
        public void GivenEnterPassword1()
        {
            loginpage.setPassword(Hooks.config.Stage.HCL_QA.Password);
        }

        [Then(@"Click on Login1")]
        public void ThenClickOnLogin1()
        {
            loginpage.Loginbutton();
        }
        [Then(@"Select the client")]
        public void ThenSelectTheClient()
        {
            Task.selectclient("Demo Solar");
        }

        [Then(@"upload the task template")]
        public void ThenUploadTheTaskTemplate()
        {
            Task.clickadd();
        }

        [Then(@"click on import")]
        public void ThenClickOnImport()
        {
            Task.import();
        }

    }
}
