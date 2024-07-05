using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiaplazaTask.Pages
{
    public class OnlineHighSchoolPage
    {
        public IWebDriver  driver;

        public OnlineHighSchoolPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement ApplyToOurSchoolLink => driver.FindElement(By.CssSelector(".wp-block-button__link.has-theme-palette-2-background-color.has-background"));

        public void ClickApplyToOurSchoolLink()
        {
            ApplyToOurSchoolLink.Click();
        }


    }
}
