using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HPATechnicalChallengeAutomation
{
    class Program
    {

        static void Main(string[] args)
        {

            IWebDriver driver = new ChromeDriver();

            // Navigate to test URL
            driver.Navigate().GoToUrl("http://hpadevtest.azurewebsites.net/");


            // Step 1 click Box 1
            driver.FindElement(By.Id("Box1")).Click();

            //Dismiss Alert
            DismissAlert();

            // Step 2 set focus on Box 2 and send the 'tab' key
            driver.FindElement(By.Id("Box3")).SendKeys(Keys.Tab);

            //Dismiss Alert
            DismissAlert();

            // Step 3 select radio button
            String optionVal = driver.FindElement(By.Id("optionVal")).Text;
            var radioButton = driver.FindElement(By.XPath($"//input[@value='{optionVal}']"));
            radioButton.Click();

            //Dismiss Alert
            DismissAlert();

            //Step 4 select can from dropdown
            String selectionVal = driver.FindElement(By.Id("selectionVal")).Text;
            SelectElement select = new SelectElement(driver.FindElement(By.XPath("//select")));
            select.SelectByValue($"{selectionVal}");

            //Dismiss Alert
            DismissAlert();


            // Step 5
            // get placeholder value and autofill input field

            var formDate = driver.FindElement(By.XPath("/html[1]/body[1]/div[5]/center[1]/div[1]/div[1]/div[1]/center[1]/table[1]/tbody[1]/tr[1]/td[1]/input[1]"));
            String formDateText = driver.FindElement(By.XPath("/html[1]/body[1]/div[5]/center[1]/div[1]/div[1]/div[1]/center[1]/table[1]/tbody[1]/tr[1]/td[1]/input[1]")).GetAttribute("placeholder");
            formDate.SendKeys(formDateText);

            var formCity = driver.FindElement(By.XPath("/html[1]/body[1]/div[5]/center[1]/div[1]/div[1]/div[1]/center[1]/table[1]/tbody[1]/tr[2]/td[1]/input[1]"));
            String formCityText = driver.FindElement(By.XPath("/html[1]/body[1]/div[5]/center[1]/div[1]/div[1]/div[1]/center[1]/table[1]/tbody[1]/tr[2]/td[1]/input[1]")).GetAttribute("placeholder");
            formCity.SendKeys(formCityText);

            var formState = driver.FindElement(By.XPath("/html[1]/body[1]/div[5]/center[1]/div[1]/div[1]/div[1]/center[1]/table[1]/tbody[1]/tr[3]/td[1]/input[1]"));
            String formStateText = driver.FindElement(By.XPath("/html[1]/body[1]/div[5]/center[1]/div[1]/div[1]/div[1]/center[1]/table[1]/tbody[1]/tr[3]/td[1]/input[1]")).GetAttribute("placeholder");
            formState.SendKeys(formStateText);

            var formCountry = driver.FindElement(By.XPath("/html[1]/body[1]/div[5]/center[1]/div[1]/div[1]/div[1]/center[1]/table[1]/tbody[1]/tr[4]/td[1]/input[1]"));
            String formCountryText = driver.FindElement(By.XPath("/html[1]/body[1]/div[5]/center[1]/div[1]/div[1]/div[1]/center[1]/table[1]/tbody[1]/tr[4]/td[1]/input[1]")).GetAttribute("placeholder");
            formCountry.SendKeys(formCountryText);

            var formDate2 = driver.FindElement(By.XPath("/html[1]/body[1]/div[5]/center[1]/div[1]/div[1]/div[1]/center[1]/table[1]/tbody[1]/tr[5]/td[1]/input[1]"));
            String formDate2Text = driver.FindElement(By.XPath("/html[1]/body[1]/div[5]/center[1]/div[1]/div[1]/div[1]/center[1]/table[1]/tbody[1]/tr[5]/td[1]/input[1]")).GetAttribute("placeholder");
            formDate2.SendKeys(formDate2Text);

            var formCity2 = driver.FindElement(By.XPath("/html[1]/body[1]/div[5]/center[1]/div[1]/div[1]/div[1]/center[1]/table[1]/tbody[1]/tr[6]/td[1]/input[1]"));
            String formCity2Text = driver.FindElement(By.XPath("/html[1]/body[1]/div[5]/center[1]/div[1]/div[1]/div[1]/center[1]/table[1]/tbody[1]/tr[6]/td[1]/input[1]")).GetAttribute("placeholder");
            formCity2.SendKeys(formCity2Text);

            var formState2 = driver.FindElement(By.XPath("/html[1]/body[1]/div[5]/center[1]/div[1]/div[1]/div[1]/center[1]/table[1]/tbody[1]/tr[7]/td[1]/input[1]"));
            String formState2Text = driver.FindElement(By.XPath("/html[1]/body[1]/div[5]/center[1]/div[1]/div[1]/div[1]/center[1]/table[1]/tbody[1]/tr[7]/td[1]/input[1]")).GetAttribute("placeholder");
            formState2.SendKeys(formState2Text);

            var formCountry2 = driver.FindElement(By.XPath("/html[1]/body[1]/div[5]/center[1]/div[1]/div[1]/div[1]/center[1]/table[1]/tbody[1]/tr[8]/td[1]/input[1]"));
            String formCountry2Text = driver.FindElement(By.XPath("/html[1]/body[1]/div[5]/center[1]/div[1]/div[1]/div[1]/center[1]/table[1]/tbody[1]/tr[8]/td[1]/input[1]")).GetAttribute("placeholder");
            formCountry2.SendKeys(formCountry2Text);

            var formDate3 = driver.FindElement(By.XPath("/html[1]/body[1]/div[5]/center[1]/div[1]/div[1]/div[1]/center[1]/table[1]/tbody[1]/tr[9]/td[1]/input[1]"));
            String formDate3Text = driver.FindElement(By.XPath("/html[1]/body[1]/div[5]/center[1]/div[1]/div[1]/div[1]/center[1]/table[1]/tbody[1]/tr[9]/td[1]/input[1]")).GetAttribute("placeholder");
            formDate3.SendKeys(formDate3Text);

            var submitButton = driver.FindElement(By.XPath("//button[contains(text(),'Submit')]"));
            submitButton.Click();

            //Dismiss Alert
            DismissAlert();

            // Step 6 scroll to x and insert result of step 5

            var result = driver.FindElement(By.Id("formResult")).Text;
            var inputNumStr = driver.FindElement(By.Id("lineNum")).Text;
            var inputNum = Convert.ToInt32(inputNumStr);
            var resultInput = driver.FindElement(By.XPath($"/html[1]/body[1]/div[4]/center[1]/div[1]/center[1]/table[1]/tbody[1]/tr[{inputNum}]/td[2]/input[1]"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView(true);", resultInput);
            resultInput.Clear();
            resultInput.SendKeys(result);
            resultInput.SendKeys(Keys.Enter);

            //Dismiss Alert
            DismissAlert();

            // Step 7 click Box 7 and wait
            for(var i = 7; i <= 10; i++)
            {
            driver.FindElement(By.Id($"Box{i}")).Click();
            Thread.Sleep(6000);
            //Dismiss Alert
            DismissAlert();
            }

            void DismissAlert()
            {
                // Dismiss Alert
                driver.SwitchTo().Alert().Accept();
            }
        }
    }
}
