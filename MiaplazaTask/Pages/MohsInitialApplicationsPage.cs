using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiaplazaTask.Pages
{
    public class MohsInitialApplicationsPage
    {
        public  IWebDriver driver;
        public MohsInitialApplicationsPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //Page Objects Parent Information Section 

        IWebElement FirstName => driver.FindElement(By.CssSelector("input[name='Name'][type='text'][aria-labelledby='Name-arialabel aria-showelemslabel-Name0 ariarequired-Name0']"));

        IWebElement LastName => driver.FindElement(By.CssSelector("input[name='Name'][type='text'][aria-labelledby='Name-arialabel aria-showelemslabel-Name1 ariarequired-Name1']"));

        IWebElement Email => driver.FindElement(By.CssSelector("input[id='Email-arialabel']"));

        IWebElement PhoneNumber => driver.FindElement(By.CssSelector("input[id='PhoneNumber']"));

        IWebElement SecondParentGuardianDropDown => driver.FindElement(By.CssSelector("select[id='Dropdown-arialabel']"));

        IWebElement FacebookInstagramCheckBox => driver.FindElement(By.CssSelector("input[id='Checkbox_1']"));

        IWebElement StartDateCalenderIcon => driver.FindElement(By.CssSelector("div[id='DatedateDiv'] img[title='...']"));

        IWebElement StartDateCalender => driver.FindElement(By.CssSelector("table[class='ui-datepicker-calendar']"));

        IWebElement NextCalender => driver.FindElement(By.CssSelector("table[class='ui-datepicker-calendar']"));

        IWebElement StartingDate => driver.FindElement(By.CssSelector("table[class='ui-datepicker-calendar'] > tbody>tr:nth-child(3)>td+td>a"));

        IWebElement NextStep => driver.FindElement(By.CssSelector("body > div:nth-child(7) > div:nth-child(1) > div:nth-child(2) > div:nth-child(1) > form:nth-child(3) > div:nth-child(11) >ul:nth-child(3)>li>div>div>div>button"));

        //Page Objects Student information Section 

        IWebElement StudentInfoHeader => driver.FindElement(By.CssSelector("li[id='Section3-li']>h2>div>b"));

        public void FillParentFirstName(string firstName)
        {
            FirstName.SendKeys(firstName);
        }

        public void FillParentLastName(string lastName)
        {
            LastName.SendKeys(lastName);
        }

        public void FillParentEmail(string email)
        {
            Email.SendKeys(email);
        }

        public void FillParentPhoneNumber(string phoneNumber)
        {
            PhoneNumber.SendKeys(phoneNumber);
        }
        public void SelectNoFillSecondParentGuardian(string descision)
        {
            var selectDecision = new SelectElement(SecondParentGuardianDropDown);
            selectDecision.SelectByValue(descision);

        }
        public void CheckFacebbokInstagramOption()
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(FacebookInstagramCheckBox).Click().Build().Perform();
        

        }

        public void SelectStartDate()
        {
           StartDateCalenderIcon.Click();
           NextCalender.Click();
           StartingDate.Click();

        }
        public void ClickParentPAgeNextButton()
        {
            Actions actions = new Actions(driver);
            actions.MoveToElement(NextStep).Click().Build().Perform();
        
         

        }


        //Student Information 

        public string GetStudentInformationHeader()
        {
            return StudentInfoHeader.Text;
        }
    }
}
