using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiaplazaTask.Pages
{
    
   public  class MiacademyLandingPage
    {
        public IWebDriver driver;

        public MiacademyLandingPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement Miacademylink => driver.FindElement(By.CssSelector("a[href='https://miaprep.com/online-school/']"));

        IWebElement Parent => driver.FindElement(By.CssSelector("a[class='mia-link0']"));
        public void ClickMiacademyLink()
        {
            Miacademylink.Click();
        }

        public void ClickChild()
        {
            Parent.Click();
        }



    }
}
