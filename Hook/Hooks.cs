/*Hook file
 Hooking Json and report generation
*/

using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Bindings;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Gherkin.Model;
using Lens_Demo.Utility;
using Microsoft.Extensions.Configuration;
using Lens_Demo.POM;



namespace Lens_Demo.Hook
{
    [Binding]
    public class Hooks
    {

       
       public static ExtentReports extent;

       public static ExtentTest test;
       public static ExtentTest feature;
       public static ExtentTest scenario,steps;
       public static ExtentTest _scenario;


        
        static string reportpath = System.IO.Directory.GetParent(@"../../../").FullName + Path.DirectorySeparatorChar
            + "Report" + Path.DirectorySeparatorChar + "Report_" + DateTime.Now.ToString("ddMMyyyy HHmmss");

        static string screenshotpath = System.IO.Directory.GetParent(@"../../../").FullName + Path.DirectorySeparatorChar
           + "Screenshots" + Path.DirectorySeparatorChar + "Screenshots" + DateTime.Now.ToString("ddMMyyyy HHmmss");


        public static Json_input config;
        static string configsettingpath = System.IO.Directory.GetParent(@"../../../").FullName
            + Path.DirectorySeparatorChar + "Input_Source/Source.json";

        [BeforeTestRun]

        public static void BeforeTestRun()
        {
            var img = new DirectoryInfo(System.IO.Directory.GetParent(@"../../../").FullName + Path.DirectorySeparatorChar
                + "Screenshots");
            FileInfo[] files = img.GetFiles();
            foreach (FileInfo file in files)
            {
                file.Delete();
            }
            ExtentHtmlReporter htmlreport = new ExtentHtmlReporter(reportpath);
            extent = new AventStack.ExtentReports.ExtentReports();
            extent.AttachReporter(htmlreport);
                       

           
            config = new Json_input();
            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.AddJsonFile(configsettingpath);
            IConfigurationRoot configuration = builder.Build();
            configuration.Bind(config);


        }
        
        [BeforeFeature]
        public static void BeforeFeature(FeatureContext context)
        {
            feature = extent.CreateTest(context.FeatureInfo.Title);
        }

        [BeforeScenario]
        public void BeforeScenario(ScenarioContext context)
        {
            //Assert.Ignore("Login with a valid user having Admin, Gatherer and Reviewer Access");
            scenario = feature.CreateNode(context.ScenarioInfo.Title);
        }

        [BeforeStep]
        public void BeforeStep()
        {
            steps = scenario;
        }

        [AfterStep]
        public void AfterStep(ScenarioContext context)
        {

            if (context.TestError == null)
            {
                steps.Log(Status.Pass, context.StepContext.StepInfo.Text);
            }
            else if (context.TestError != null)
            {
                steps.Log(Status.Fail, context.StepContext.StepInfo.Text).Fail(context.TestError.ToString());
                //steps.Log(Status.Fail, context.StepContext.StepInfo.Text).Fail(context.TestError.StackTrace);


                ((ITakesScreenshot)Environmentev.webDriver).GetScreenshot().SaveAsFile(screenshotpath + context, ScreenshotImageFormat.Png);
                string path = screenshotpath + context;
                
                
                steps.AddScreenCaptureFromPath(path);
               Console.WriteLine(screenshotpath);
                

                

            }




        }

        [AfterFeature]
        public static void AfterFeature()
        {
            extent.Flush();
            //Environmentev.webDriver.Quit();
        }
    }
}
    







