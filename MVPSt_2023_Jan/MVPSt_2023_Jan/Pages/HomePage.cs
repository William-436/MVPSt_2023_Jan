using MVPSt_2023_Jan.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using static MVPSt_2023_Jan.Utilities.CommonDriver;

namespace MVPSt_2023_Jan.Pages
{
    public class HomePage
    {
        public void NavigateToDescription()
        {
            // find and click the Description edit icon to open the Description textbox
            Wait.WaitForElementToBeClickable("XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i", 2);
            IWebElement editDescLink = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i"));
            editDescLink.Click();
        }
        public void SetSellersDescription(string NewDesc)
        {
            // set the seller's Description
            // find, clear, and then enter Description in Description textbox
            IWebElement descTextbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));
            descTextbox.Clear();
            descTextbox.SendKeys(NewDesc);

            // find and click the Save button
            IWebElement saveButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));
            saveButton.Click();
        }

        public void NavigateToLanguage()
        {
            // find and click the Languages tab
            IWebElement langTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            langTab.Click();
        }

        public void SetSellersLanguageAndLevel(string Language, string Level)
        {
            // find and click the Add New button for Languages
            IWebElement langaddnewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            langaddnewButton.Click();
            // set the seller's Language(s) and Level(s)
            // find, clear, and then enter Language in Language textbox
            IWebElement langTextbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            langTextbox.Clear();
            langTextbox.SendKeys(Language);
            // select level from Language Level drop-down list
            driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select")).Click();
            if (Level == "Basic")
            {
                driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[2]")).Click();
            }
            if (Level == "Conversational")
            {
                driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[3]")).Click();
            }
            if (Level == "Fluent")
            {
                driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[4]")).Click();
            }
            if (Level == "Native/Bilingual")
            {
                driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[5]")).Click();
            }
            // find and click the Add button
            IWebElement langaddButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            langaddButton.Click();
        }

        public void NavigateToEducation()
        {
            // find and click the Education tab
            IWebElement educationTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            educationTab.Click();
        }

        public void SetSellersEducation(string Country, string University, string Title, string Degree, string YearOfGrad)
        {
            // find and click the Add New button for Education
            IWebElement educationaddnewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            educationaddnewButton.Click();
            // find and set all 5 of the seller's Education fields
            // find and enter the University
            IWebElement eduniversityTextbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));
            eduniversityTextbox.SendKeys(University);

            // select country from Country drop-down list
            // create object for new SelectElement class
            IWebElement countryDropDownElement = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));
            SelectElement selectacountry = new SelectElement(countryDropDownElement);
            selectacountry.SelectByText(Country);

            // select title from Title drop-down list
            // create object for new SelectElement class
            IWebElement titleDropDownElement = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select"));
            SelectElement selectatitle = new SelectElement(titleDropDownElement);
            selectatitle.SelectByText(Title);

            // find and enter the Degree
            IWebElement eddegreeTextbox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"));
            eddegreeTextbox.SendKeys(Degree);

            // select year of graduation from drop-down list
            // create object for new SelectElement class
            IWebElement yearofgradDropDownElement = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select"));
            SelectElement selectayearofgrad = new SelectElement(yearofgradDropDownElement);
            selectayearofgrad.SelectByText(YearOfGrad);

            // find and click the Add button
            IWebElement educationaddButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
            educationaddButton.Click();
        }

        public string GetDescription()
        {
            // wait for the Description edit icon to be visible/exist
            Wait.WaitForElementToExist("XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i", 4);
            
            IWebElement description = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/span"));
            return description.Text;
        }

        public string GetLanguage()
        {
            Wait.WaitForElementToExist("XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]", 4);
            // added [last()] after tbody near end of XPath
            IWebElement language = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return language.Text;
        }

        public string GetLanguageLevel()
        {
            // added [last()] after tbody near end of XPath
            IWebElement level = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return level.Text;
        }

        public string GetCountry()
        {
            // wait for the Cancel button to NOT be visible/exist
            //Wait.WaitForElementToExist(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i", 4);
            // wait for the Country to appear in the table
            Wait.WaitForElementToExist("XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[1]", 4);
            // added [last()] after tbody near end of XPath
            IWebElement country = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[1]"));
            return country.Text;
        }

        public string GetUniversity()
        {
            // added [last()] after tbody near end of XPath
            IWebElement university = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[2]"));
            return university.Text;
        }

        public string GetTitle()
        {
            // added [last()] after tbody near end of XPath
            IWebElement title = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[3]"));
            return title.Text;
        }

        public string GetDegree()
        {
            // added [last()] after tbody near end of XPath
            IWebElement degree = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[4]"));
            return degree.Text;
        }

        public string GetYearOfGrad()
        {
            // added [last()] after tbody near end of XPath
            IWebElement yearofgrad = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[5]"));
            return yearofgrad.Text;
        }

        //public void DeleteLanguages(IWebDriver driver)
        //{
        //    // if a Language - Level exists, then delete it until all are gone
        //    if (driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]/i")).
        //}

        public void SignOut()
        {
            // sign out of Trade Your Skills portal
            // find and click the Sign Out button
            IWebElement signoutButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/a[2]/button"));
            signoutButton.Click();
            // wait for the Sign In button to appear
            Wait.WaitForElementToBeClickable("XPath", "//*[@id=\"home\"]/div/div/div[1]/div/a", 2);
            IWebElement button2Label = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
            // if button label is Sign In, then set variable to true, otherwise false
            if (button2Label.Text == "Sign In")
            {
                //success = true;
                Console.WriteLine("Successfully Signed Out of Onboarding portal");
            }
            else
            {
                //success = false;
                Console.WriteLine("Failed to Sign Out of Onboarding portal");
            }
            //Assert.That(sobuttonLabel.Text == "Sign Out", "Failed to Login successfully");
            //return success;
        }
    }
}
