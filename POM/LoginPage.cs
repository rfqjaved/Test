using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using Lens_Demo.Utility;

namespace Lens_Demo.POM
{
    class LoginPage
    {
        
        public LoginPage(IWebDriver webDriver)
        {
            Environmentev.webDriver = webDriver;
        }
        public By LoginInput = By.Id("email");
        public By password = By.Name("password");
        public By Loginbtn = By.XPath("//input[@type='submit' and @value ='Login']");
        public By verifyLogin = By.XPath("//span[contains(., 'Dashboard')]");


        public void itemdisplay(string item)
        {
            Environmentev.webDriver.FindElement(Loginbtn);
        }
        public void setUserName(string email)
        {
            Environmentev.webDriver.FindElement(LoginInput).SendKeys(email);
        }

        public void setPassword(string pass)
        {
            Environmentev.webDriver.FindElement(password).SendKeys(pass);
        }
        
        

        public void Loginbutton()
        {
            Environmentev.webDriver.FindElement(Loginbtn).Click();
        }

        public void Verify()
        {
            Environmentev.webDriver.FindElement(verifyLogin);
        }
    }          

}
