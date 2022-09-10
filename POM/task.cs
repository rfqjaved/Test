using Lens_Demo.Utility;
using OpenQA.Selenium;
using System.Threading;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Support.UI;


namespace Lens_Demo.POM
{
    class task
    {
        public task(IWebDriver webDriver)
        {
            Environmentev.webDriver = webDriver;
        }
        public By client = By.Name("client");
        public By fileadd = By.CssSelector("input[type='file']");
        public By clickimport = By.XPath("//*[@id=\'page-wrapper\']/div/form/div[4]/div/button[1]");

        public void selectclient(string cl)
        {
            Environmentev.webDriver.Navigate().GoToUrl("https://lens-qa.radiangen.com/#/entity/tasks/import");
            Thread.Sleep(2000);
            
            var comboBox = Environmentev.webDriver.FindElement(client);
            new SelectElement(comboBox).SelectByText(cl);
        }
        public void clickadd()
        {
            Environmentev.webDriver.FindElement(fileadd).SendKeys("C:\\Users\\rafique.javed\\Downloads\\tasks_17_template.xlsx");

        }
        public void import()
        {
            Environmentev.webDriver.FindElement(clickimport);
        }
    }
}
