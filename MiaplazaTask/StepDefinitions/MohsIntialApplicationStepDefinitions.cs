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


        IWebDriver driver = ScenarioContext.Current.Get<IWebDriver>("webDriver");

        MiacademyLandingPage landingPage;
        OnlineHighSchoolPage onlineSchoolPage;
        MohsInitialApplicationsPage initialApplicationsPage;

        [Given(@"Navigate to Miacademy page")]
        public void GivenNavigateToMiacademyPage()
        {
            //Open the web broweser and navigate to application

            driver.Navigate().GoToUrl("https://miacademy.co/#/");
            
        }

        [When(@"Navigate to online high school and apply to school")]
        public void WhenNavigateToOnlineHighSchoolAndApplyToSchool()
        {
            //Navigate to online school page 

            landingPage = new MiacademyLandingPage(driver);
            landingPage.ClickMiacademyLink();

            //Apply for online school 
            onlineSchoolPage = new OnlineHighSchoolPage(driver);
            onlineSchoolPage.ClickApplyToOurSchoolLink();

        }

      
      


    [When(@"Fill Out parent information and navigate to next page")]
    public void WhenFillOutParentInformationAndNavigateToNextPage(Table table)
    {
            ParentDetials parentInfo =  table.CreateInstance<ParentDetials>();

            // Fill out parent detials 
            initialApplicationsPage = new MohsInitialApplicationsPage(driver);
            initialApplicationsPage.FillParentFirstName(parentInfo.FirstName);
            initialApplicationsPage.FillParentLastName(parentInfo.LastName);
            initialApplicationsPage.FillParentEmail(parentInfo.Email);
            initialApplicationsPage.FillParentPhoneNumber(parentInfo.PhoneNumber);
            initialApplicationsPage.SelectNoFillSecondParentGuardian("No");
            initialApplicationsPage.CheckFacebbokInstagramOption();
            initialApplicationsPage.SelectStartDate();

            //Navigate to Student information page
            initialApplicationsPage.ClickParentPAgeNextButton();
        }


        [Then(@"Verify User navigate to Student Information Page")]
        public void ThenVerifyUserNavigateToStudentInformationPage()
        {
            initialApplicationsPage = new MohsInitialApplicationsPage(driver);

            //Verify the student information page header 
            Assert.AreEqual("Student Information", initialApplicationsPage.GetStudentInformationHeader());

        

        }

    }

}