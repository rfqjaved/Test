using OpenQA.Selenium;
using Lens_Demo.Utility;
using OpenQA.Selenium.Interactions;

namespace Lens_Demo.POM
{
    class HomePage
    {
        
        public HomePage(IWebDriver webDriver)
        {
            Environmentev.webDriver = webDriver; 
        }

        public By homepage = By.XPath("//span[contains(., 'Dashboard')]");
        public By Client = By.XPath("//span[contains(text(), 'Clients')]");
        public By AddClient = By.XPath("//a[contains(text(), 'Add New Client')]");
        public By CLientList1 = By.XPath("//a[contains(text(), 'Manage Clients')]");
        public By CLientList = By.XPath("//a[@href ='#/entity/clients/list']");
        



        public string getText()
        {
            return Environmentev.webDriver.FindElement(homepage).Text;
            
        }
        
        public bool elementdisplayed()
        {
            return Environmentev.webDriver.FindElement(homepage).Displayed;
        }
       
        public void Clientclick()
        {
            //Environmentev.webDriver.FindElement(Client).Click();
            //Environmentev.webDriver.FindElement(AddClient).Click();
            Environmentev.webDriver.Navigate().GoToUrl("https://lens-qa.radiangen.com/#/entity/clients/add");
        }
        public void ClientclickList()
        {
            //Environmentev.webDriver.FindElement(Client).Click();
            //Actions builder = new Actions(Environmentev.webDriver);
           // builder.MoveToElement(Environmentev.webDriver.FindElement(Client)).Click().Build().Perform();   
            Environmentev.webDriver.FindElement(CLientList).Click();
            Environmentev.webDriver.FindElement(CLientList1).Click();
        }

    }
}
