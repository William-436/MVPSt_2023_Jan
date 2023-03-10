using MVPSt_2023_Jan.Pages;
using MVPSt_2023_Jan.Utilities;
using NUnit.Framework;


namespace MVPSt_2023_Jan.StepDefinitions
{
    [Binding]

    public class SellerProfileFeatureStepDefinitions : CommonDriver
    {
        // define Pages and Objects
        HomePage homePageObj;

        // default constructor
        public SellerProfileFeatureStepDefinitions()
        {
            // initialize page objects
            //tysportalPageObj = new TYSPortalPage();
            homePageObj = new HomePage();
        }

        [Given(@"I have signed into Trade Your Skill portal successfully using email ""([^""]*)"" and password ""([^""]*)""")]
        public void GivenIHaveSignedIntoTradeYourSkillPortalSuccessfullyUsingEmailAndPassword(string Email, string Pswd)
        {
            SignIntoTRSPortal();
        }

        [When(@"Seller navigates to the Description")]
        public void WhenSellerNavigatesToTheDescription()
        {
            homePageObj.NavigateToDescription();
        }

        [When(@"Seller enters a new Description '([^']*)'")]
        public void WhenSellerEntersANewDescription(string NewDesc)
        {
            homePageObj.SetSellersDescription(NewDesc);
        }

        [Then(@"The Sellers Profile Description was entered as ""([^""]*)""")]
        public void ThenTheSellersProfileDescriptionWasEnteredAs(string NewDesc)
        {
            string savedDescription = homePageObj.GetDescription();

            if (savedDescription == NewDesc)
            {
                Console.WriteLine("Passed: Actual saved Description matches expected Description");
            }
            else
            {
                Console.WriteLine("Failed: See actual and expected values in the following 2 lines");
                Console.WriteLine($"{savedDescription}");
                Console.WriteLine($"{NewDesc}");
                Assert.Fail("Failed: Actual saved Description does not match expected Description");
            }
        }

        [Then(@"The Sellers Profile Description '([^']*)' is invalid")]
        public void ThenTheSellersProfileDescriptionIsInvalid(string p0)
        {
            throw new PendingStepException();
        }

        [When(@"Seller navigates to Language")]
        public void WhenSellerNavigatesToLanguage()
        {
            homePageObj.NavigateToLanguage();
        }

        [When(@"Seller enters Language '([^']*)' and Level '([^']*)'")]
        public void WhenSellerEntersLanguageAndLevel(string Language, string Level)
        {
            homePageObj.SetSellersLanguageAndLevel(Language, Level);
        }

        [Then(@"The Sellers Profile Language and Level were entered as '([^']*)' and '([^']*)'")]
        public void ThenTheSellersProfileLanguageAndLevelWereEnteredAsAnd(string Language, string Level)
        {
            string savedLanguage = homePageObj.GetLanguage();
            string savedLevel = homePageObj.GetLanguageLevel();

            if (savedLanguage == Language && savedLevel == Level)
            {
                Console.WriteLine("Passed: Actual saved Language-Level matches expected Language-Level");
                Console.WriteLine($"{savedLanguage} / {savedLevel}");
            }
            else
            {
                Console.WriteLine("Failed: See actual and expected values in the following 2 lines");
                Console.WriteLine($"{savedLanguage} {savedLevel}");
                Console.WriteLine($"{Language} {Level}");
                Assert.Fail("Failed: Actual saved Language-Level do not match expected Language-Level");
            }
        }

        [When(@"Seller enters invalid Language '([^']*)' and Level '([^']*)'")]
        public void WhenSellerEntersInvalidLanguageAndLevel(string p0, string p1)
        {
            throw new PendingStepException();
        }

        [Then(@"The Sellers Profile Language and Level of '([^']*)' and '([^']*)' are invalid")]
        public void ThenTheSellersProfileLanguageAndLevelOfAndAreInvalid(string p0, string p1)
        {
            throw new PendingStepException();
        }

        [When(@"Seller navigates to Skill")]
        public void WhenSellerNavigatesToSkill()
        {
            throw new PendingStepException();
        }

        [When(@"Seller enters Skill '([^']*)' and Skill Level '([^']*)'")]
        public void WhenSellerEntersSkillAndSkillLevel(string leadership, string expert)
        {
            throw new PendingStepException();
        }

        [Then(@"The Sellers Profile Skill and Skill Level were entered as '([^']*)' and '([^']*)'")]
        public void ThenTheSellersProfileSkillAndSkillLevelWereEnteredAsAnd(string leadership, string expert)
        {
            throw new PendingStepException();
        }

        [When(@"Seller enters invalid Skill '([^']*)' and Level '([^']*)'")]
        public void WhenSellerEntersInvalidSkillAndLevel(string p0, string expert)
        {
            throw new PendingStepException();
        }

        [Then(@"The Sellers Profile Skill and Skill Level of '([^']*)' and '([^']*)' are invalid")]
        public void ThenTheSellersProfileSkillAndSkillLevelOfAndAreInvalid(string p0, string expert)
        {
            throw new PendingStepException();
        }

        [When(@"Seller navigates to Education")]
        public void WhenSellerNavigatesToEducation()
        {
            homePageObj.NavigateToEducation();
        }

        [When(@"Seller enters Education '([^']*)' '([^']*)' '([^']*)' '([^']*)' and '([^']*)'")]
        public void WhenSellerEntersEducationAnd(string Country, string University, string Title, string Degree, string YearOfGrad)
        {
            homePageObj.SetSellersEducation(Country, University, Title, Degree, YearOfGrad);
        }

        [Then(@"The Sellers Profile Education was entered as '([^']*)' '([^']*)' '([^']*)' '([^']*)' and '([^']*)'")]
        public void ThenTheSellersProfileEducationWasEnteredAsAnd(string Country, string University, string Title, string Degree, string YearOfGrad)
        {
            string savedCountry = homePageObj.GetCountry();
            string savedUniversity = homePageObj.GetUniversity();
            string savedTitle = homePageObj.GetTitle();
            string savedDegree = homePageObj.GetDegree();
            string savedYearOfGrad = homePageObj.GetYearOfGrad();

            if (savedCountry == Country && savedUniversity == University && savedTitle == Title && savedDegree == Degree && savedYearOfGrad == YearOfGrad)
            {
                Console.WriteLine("Passed: Actual saved Education matches expected Education");
            }
            else
            {
                Console.WriteLine("Failed: See actual, then expected values in the following 2 lines, respectively");
                Console.WriteLine($"{savedCountry} {savedUniversity} {savedTitle} {savedDegree} {savedYearOfGrad}");
                Console.WriteLine($"{Country} {University} {Title} {Degree} {YearOfGrad}");
                Assert.Fail("Failed: Actual saved Education does not match expected Education");
            }
        }

        [When(@"Seller enters invalid Education '([^']*)' '([^']*)' '([^']*)' '([^']*)' and '([^']*)'")]
        public void WhenSellerEntersInvalidEducationAnd(string p0, string p1, string p2, string p3, string p4)
        {
            throw new PendingStepException();
        }

        [Then(@"The Sellers Profile Education of '([^']*)' '([^']*)' '([^']*)' '([^']*)' and '([^']*)' is invalid")]
        public void ThenTheSellersProfileEducationOfAndIsInvalid(string p0, string p1, string p2, string p3, string p4)
        {
            throw new PendingStepException();
        }

        [When(@"Seller navigates to Certifications")]
        public void WhenSellerNavigatesToCertifications()
        {
            throw new PendingStepException();
        }

        [When(@"Seller enters Certificate '([^']*)' '([^']*)' and '([^']*)'")]
        public void WhenSellerEntersCertificateAnd(string p0, string p1, string p2)
        {
            throw new PendingStepException();
        }

        [When(@"Seller enters invalid Certificate '([^']*)' '([^']*)' and '([^']*)'")]
        public void WhenSellerEntersInvalidCertificateAnd(string p0, string p1, string p2)
        {
            throw new PendingStepException();
        }

        [Then(@"The Sellers Profile Certificate\(s\) was\(were\) entered as '([^']*)' '([^']*)' and '([^']*)'")]
        public void ThenTheSellersProfileCertificateSWasWereEnteredAsAnd(string p0, string p1, string p2)
        {
            throw new PendingStepException();
        }

        [Then(@"The Sellers Profile Certificate of '([^']*)' '([^']*)' and '([^']*)' is invalid")]
        public void ThenTheSellersProfileCertificateOfAndIsInvalid(string p0, string p1, string p2)
        {
            throw new PendingStepException();
        }

        [When(@"Seller navigates to Availability")]
        public void WhenSellerNavigatesToAvailability()
        {
            throw new PendingStepException();
        }

        [When(@"Seller enters Availability of '([^']*)'")]
        public void WhenSellerEntersAvailabilityOf(string p0)
        {
            throw new PendingStepException();
        }

        [Then(@"The Sellers Profile Availability was entered as '([^']*)'")]
        public void ThenTheSellersProfileAvailabilityWasEnteredAs(string p0)
        {
            throw new PendingStepException();
        }

        [When(@"Seller navigates to Hours")]
        public void WhenSellerNavigatesToHours()
        {
            throw new PendingStepException();
        }

        [When(@"Seller enters Hours of '([^']*)'")]
        public void WhenSellerEntersHoursOf(string p0)
        {
            throw new PendingStepException();
        }

        [Then(@"The Sellers Profile Hours were entered as '([^']*)'")]
        public void ThenTheSellersProfileHoursWereEnteredAs(string p0)
        {
            throw new PendingStepException();
        }

        [When(@"Seller navigates to Earnings Target")]
        public void WhenSellerNavigatesToEarningsTarget()
        {
            throw new PendingStepException();
        }

        [When(@"Seller enters Earnings Target '([^']*)'")]
        public void WhenSellerEntersEarningsTarget(string p0)
        {
            throw new PendingStepException();
        }

        [Then(@"The Sellers Profile Earnings Target was entered as '([^']*)'")]
        public void ThenTheSellersProfileEarningsTargetWasEnteredAs(string p0)
        {
            throw new PendingStepException();
        }

        [When(@"Five thousand sellers navigate to their Profile Language page")]
        public void WhenFiveThousandSellersNavigateToTheirProfileLanguagePage()
        {
            throw new PendingStepException();
        }

        [When(@"Sellers enter Kareokee and Fluent")]
        public void WhenSellersEnterKareokeeAndFluent()
        {
            throw new PendingStepException();
        }

        [Then(@"Trade Your Skills portal stops responding")]
        public void ThenTradeYourSkillsPortalStopsResponding()
        {
            throw new PendingStepException();
        }

        [AfterScenario]
        public void AfterScenarioCleanup()
        {
            // sign out and check returned boolean value to see if successful
            if (homePageObj.SignOut() == true)
            {
                Console.WriteLine("Successfully Signed out of Onboarding portal");
            }
            else
            {
                Console.WriteLine("Failed to Sign Out of Onboarding portal");
            }
            CloseTestRun();
        }
    }
}
