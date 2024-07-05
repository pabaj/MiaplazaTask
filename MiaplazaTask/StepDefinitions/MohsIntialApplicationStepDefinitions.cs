using MiaplazaTask.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow.Assist;

namespace MiaplazaTask.StepDefinitions
{
    [Binding]
    public sealed class MohsIntialApplicationStepDefinitions
    {

        private IWebDriver driver;
        MiacademyLandingPage landingPage;
        OnlineHighSchoolPage onlineSchoolPage;
        MohsInitialApplicationsPage initialApplicationsPage;


        [Given(@"Navigate to Miacademy page")]
        public void GivenNavigateToMiacademyPage()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Navigate().GoToUrl("https://miacademy.co/#/");
            
        }

        [When(@"Navigate to online high school and apply to school")]
        public void WhenNavigateToOnlineHighSchoolAndApplyToSchool()
        {
            landingPage = new MiacademyLandingPage(driver);
            landingPage.ClickMiacademyLink();
            onlineSchoolPage = new OnlineHighSchoolPage(driver);
            onlineSchoolPage.ClickApplyToOurSchoolLink();

        }

      
      


    [When(@"Fill Out parent information and navigate to next page")]
    public void WhenFillOutParentInformationAndNavigateToNextPage(Table table)
    {
            ParentDetials parentInfo =  table.CreateInstance<ParentDetials>();

            initialApplicationsPage = new MohsInitialApplicationsPage(driver);
            initialApplicationsPage.FillParentFirstName(parentInfo.FirstName);
            initialApplicationsPage.FillParentLastName(parentInfo.LastName);
            initialApplicationsPage.FillParentEmail(parentInfo.Email);
            initialApplicationsPage.FillParentPhoneNumber(parentInfo.PhoneNumber);
            initialApplicationsPage.SelectNoFillSecondParentGuardian("No");
            initialApplicationsPage.CheckFacebbokInstagramOption();
            initialApplicationsPage.SelectStartDate();
            initialApplicationsPage.ClickParentPAgeNextButton();
        }


        [Then(@"Verify User navigate to Student Information Page")]
        public void ThenVerifyUserNavigateToStudentInformationPage()
        {
            initialApplicationsPage = new MohsInitialApplicationsPage(driver);
            Assert.AreEqual("Student Information", initialApplicationsPage.GetStudentInformationHeader());
            driver.Quit();

        }

    }

}