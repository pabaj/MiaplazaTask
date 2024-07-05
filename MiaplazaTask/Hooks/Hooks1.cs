using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace MiaplazaTask.Hooks
{
    [Binding]
    public sealed class Hooks1
    {
        
       
        
        [BeforeScenario("@tag1")]
        public void BeforeScenarioWithTag()
        {
           
        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
            // open a browser 
            var driver = new ChromeDriver();
            ScenarioContext.Current["webDriver"] = driver;
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

           
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //close the browser

           
                var driver = new ChromeDriver();
                driver.Close();
            
            


            
        }
    }
}