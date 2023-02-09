using MVPSt_2023_Jan.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using static MVPSt_2023_Jan.Utilities.CommonDriver;

namespace MVPSt_2023_Jan.Pages
{
    public class HomePage
    {
        // page objects
        // Description objects
        private IWebElement editDescriptionLink => driver.FindElement(By.XPath(editDescriptionLinkXP));
        private IWebElement descriptionTextbox => driver.FindElement(By.XPath(descriptionTextboxXP));
        private IWebElement descriptionSaveButton => driver.FindElement(By.XPath(descriptionSaveButtonXP));

        // Description - Get element used to validate Actual against Expected data
        private IWebElement description => driver.FindElement(By.XPath(descriptionXP));

        // Languages objects
        private IWebElement languagesTab => driver.FindElement(By.XPath(languagesTabXP));
        private IWebElement languageaddnewButton => driver.FindElement(By.XPath(languageaddnewButtonXP));
        private IWebElement languageTextbox => driver.FindElement(By.XPath(languageTextboxXP));
        private IWebElement languagelevelDropDown => driver.FindElement(By.XPath(languagelevelDropDownXP));
        private IWebElement languagelevelbasic => driver.FindElement(By.XPath(languagelevelBasicXP));
        private IWebElement languagelevelconversational => driver.FindElement(By.XPath(languagelevelConversationalXP));
        private IWebElement languagelevelfluent => driver.FindElement(By.XPath(languagelevelFluentXP));
        private IWebElement languagelevelnativebilingual => driver.FindElement(By.XPath(languagelevelNativeBilingualXP));
        private IWebElement languageaddButton => driver.FindElement(By.XPath(languageaddButtonXP));

        // Languages - Get elements used to validate Actual against Expected data
        private IWebElement language => driver.FindElement(By.XPath(languageXP));
        private IWebElement languagelevel => driver.FindElement(By.XPath(languagelevelXP));

        // Education objects
        private IWebElement educationTab => driver.FindElement(By.XPath(educationTabXP));
        private IWebElement educationaddnewButton => driver.FindElement(By.XPath(educationaddnewButtonXP));
        private IWebElement educationuniversityTextbox => driver.FindElement(By.XPath(educationuniversityTextboxXP));
        private IWebElement educationcountryDropDown => driver.FindElement(By.XPath(educationcountryDropDownXP));
        private IWebElement educationtitleDropDown => driver.FindElement(By.XPath(educationtitleDropDownXP));
        private IWebElement educationdegreeTextbox => driver.FindElement(By.XPath(educationdegreeTextboxXP));
        private IWebElement educationyearofgradDropDown => driver.FindElement(By.XPath(educationyearofgradDropDownXP));
        private IWebElement educationaddButton => driver.FindElement(By.XPath(educationaddButtonXP));

        // Education - Get elements used to validate Actual against Expected data
        private IWebElement educationcountry => driver.FindElement(By.XPath(educationcountryXP));
        private IWebElement educationuniversity => driver.FindElement(By.XPath(educationuniversityXP));
        private IWebElement educationtitle => driver.FindElement(By.XPath(educationtitleXP));
        private IWebElement educationdegree => driver.FindElement(By.XPath(educationdegreeXP));
        private IWebElement educationyearofgrad => driver.FindElement(By.XPath(educationyearofgradXP));

        // Miscellaneous objects
        private IWebElement signoutButton => driver.FindElement(By.XPath(signoutButtonXP));
        private IWebElement signinLink => driver.FindElement(By.XPath(signinLinkXP));

        // XPath of elements
        private string editDescriptionLinkXP = "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i";
        private string descriptionTextboxXP = "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea";
        private string descriptionSaveButtonXP = "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button";
        private string descriptionXP = "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/span";
        private string languagesTabXP = "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]";
        private string languageaddnewButtonXP = "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div";
        private string languageTextboxXP = "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input";
        private string languagelevelDropDownXP = "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select";
        private string languagelevelBasicXP = "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[2]";
        private string languagelevelConversationalXP = "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[3]";
        private string languagelevelFluentXP = "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[4]";
        private string languagelevelNativeBilingualXP = "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[5]";
        private string languageaddButtonXP = "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]";
        // added [last()] after tbody near end of XPath
        private string languageXP = "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]";
        // added [last()] after tbody near end of XPath
        private string languagelevelXP = "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]";
        private string educationTabXP = "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]";
        private string educationaddnewButtonXP = "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div";
        private string educationuniversityTextboxXP = "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input";
        private string educationcountryDropDownXP = "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select";
        private string educationtitleDropDownXP = "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select";
        private string educationdegreeTextboxXP = "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input";
        private string educationyearofgradDropDownXP = "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select";
        private string educationaddButtonXP = "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]";
        // added [last()] after tbody near end of XPath
        private string educationcountryXP = "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[1]";
        // added [last()] after tbody near end of XPath
        private string educationuniversityXP = "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[2]";
        // added [last()] after tbody near end of XPath
        private string educationtitleXP = "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[3]";
        // added [last()] after tbody near end of XPath
        private string educationdegreeXP = "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[4]";
        // added [last()] after tbody near end of XPath
        private string educationyearofgradXP = "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[last()]/tr/td[5]";
        private string signoutButtonXP = "//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/a[2]/button";
        private string signinLinkXP = "//*[@id=\"home\"]/div/div/div[1]/div/a";

        public void NavigateToDescription()
        {
            // find and click the Description edit icon to open the Description textbox
            Wait.WaitForElementToBeClickable("XPath", editDescriptionLinkXP, 2);
            editDescriptionLink.Click();
        }

        public void SetSellersDescription(string NewDesc)
        {
            // set the seller's Description
            // find, clear, and then enter Description in Description textbox
            descriptionTextbox.Clear();
            descriptionTextbox.SendKeys(NewDesc);

            // find and click the Save button
            descriptionSaveButton.Click();
        }

        public void NavigateToLanguage()
        {
            // find and click the Languages tab
            languagesTab.Click();
        }

        public void SetSellersLanguageAndLevel(string Language, string Level)
        {
            // find and click the Add New button for Languages
            languageaddnewButton.Click();

            // set the seller's Language(s) and Level(s)
            // find, clear, and then enter Language in Language textbox
            languageTextbox.Clear();
            languageTextbox.SendKeys(Language);

            // select level from Language Level drop-down list
            languagelevelDropDown.Click();
            if (Level == "Basic")
            {
                languagelevelbasic.Click();
            }
            if (Level == "Conversational")
            {
                languagelevelconversational.Click();
            }
            if (Level == "Fluent")
            {
                languagelevelfluent.Click();
            }
            if (Level == "Native/Bilingual")
            {
                languagelevelnativebilingual.Click();
            }

            // find and click the Add button
            languageaddButton.Click();
        }

        public void NavigateToEducation()
        {
            // find and click the Education tab
            educationTab.Click();
        }

        public void SetSellersEducation(string Country, string University, string Title, string Degree, string YearOfGrad)
        {
            // find and click the Add New button for Education
            educationaddnewButton.Click();

            // find and set all 5 of the seller's Education fields
            // find and enter the University
            educationuniversityTextbox.SendKeys(University);

            // select country from Country drop-down list
            // create object for new SelectElement class
            SelectElement selectacountry = new SelectElement(educationcountryDropDown);
            selectacountry.SelectByText(Country);

            // select title from Title drop-down list
            // create object for new SelectElement class
            SelectElement selectatitle = new SelectElement(educationtitleDropDown);
            selectatitle.SelectByText(Title);

            // find and enter the Degree
            educationdegreeTextbox.SendKeys(Degree);

            // select year of graduation from drop-down list
            // create object for new SelectElement class
            SelectElement selectayearofgrad = new SelectElement(educationyearofgradDropDown);
            selectayearofgrad.SelectByText(YearOfGrad);

            // find and click the Add button
            educationaddButton.Click();
        }

        public string GetDescription()
        {
            // wait for the Description edit icon to be visible/exist
            Wait.WaitForElementToExist("XPath", editDescriptionLinkXP, 4);
            
            return description.Text;
        }

        public string GetLanguage()
        {
            Wait.WaitForElementToExist("XPath", languageXP, 4);

            return language.Text;
        }

        public string GetLanguageLevel()
        {
            return languagelevel.Text;
        }

        public string GetCountry()
        {
            // wait for the Country to appear in the table
            Wait.WaitForElementToExist("XPath", educationcountryXP, 4);

            return educationcountry.Text;
        }

        public string GetUniversity()
        {
            return educationuniversity.Text;
        }

        public string GetTitle()
        {
            return educationtitle.Text;
        }

        public string GetDegree()
        {
            return educationdegree.Text;
        }

        public string GetYearOfGrad()
        {
            return educationyearofgrad.Text;
        }

        public bool SignOut()
        {
            // sign out of Trade Your Skills portal
            // find and click the Sign Out button
            if (signoutButton.Text != "Sign Out")
            {
                Console.WriteLine("Sign Out button not found - Quitting program");
                return false;
            }
            signoutButton.Click();

            // wait for the Sign In link to appear
            Wait.WaitForElementToBeClickable("XPath", signinLinkXP, 2);

            // if link label is Sign In, then set variable to true, otherwise false
            if (signinLink.Text == "Sign In")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
