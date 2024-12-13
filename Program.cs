using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V129.WebAuthn;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NEW
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IWebDriver Driver = new ChromeDriver();
           
           
            Driver.Url = "https://testautomationpractice.blogspot.com/";
            Driver.Manage().Window.Maximize();

            var Name=Driver.FindElement(By.Id("name"));
            Name.SendKeys("Gayuajs");

            var Email = Driver.FindElement(By.Id("email"));
            Email.SendKeys("saki@email.com");

            var Phone = Driver.FindElement(By.Id("phone"));
            Phone.SendKeys("9378798491");

            Actions actions = new Actions(Driver);
            IWebElement element = Driver.FindElement(By.Id("textarea"));
            actions.MoveToElement(element).Perform(); 
            element.SendKeys("78 pk street,Tuticorin");

            IWebElement GEnder = Driver.FindElement(By.XPath("//input[@type='radio' and @value='male']"));
            actions.MoveToElement(GEnder).Perform();
            GEnder.Click();

            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollBy(0, 500);"); // Scroll down by 500 pixels

          var  Checkbox =Driver.FindElements(By.XPath("//input[@class='form-check-input' and @type='checkbox']"));
            for(int i = 0; i < Checkbox.Count(); i++)
            {
                var check = Checkbox[i];
                check.Click();
            }


          var country=  Driver.FindElement(By.Id("country"));
            SelectElement oselect = new SelectElement(country);
            oselect.SelectByText("India");


            var colors = Driver.FindElement(By.Id("colors"));
            SelectElement oselect1 = new SelectElement(colors);
            oselect1.SelectByText("Red");
            Thread.Sleep(1000);
            oselect1.SelectByIndex(2);

            var SortedList = Driver.FindElement(By.Id("animals"));
            SelectElement oselect2 = new SelectElement(SortedList);
            oselect2.SelectByText("Lion");
            Thread.Sleep(1000);
            oselect2.SelectByIndex(2);

            js.ExecuteScript("window.scrollBy(0,650);");

            var datepicker1 = Driver.FindElement(By.Id("datepicker"));
            datepicker1.Click();
            var datepcker = Driver.FindElement(By.XPath("//a[@data-date='13']"));
                datepcker.Click();


            var datepicker2 = Driver.FindElement(By.Id("txtDate"));
            datepicker2.Click();

            var datepickermonth = Driver.FindElement(By.ClassName("ui-datepicker-month"));
            SelectElement oselect3 = new SelectElement(datepickermonth);
            oselect3.SelectByText("Aug");
            Thread.Sleep(1000);
            var datepickeryear = Driver.FindElement(By.ClassName("ui-datepicker-year"));
            SelectElement oselect4 = new SelectElement(datepickeryear);
            oselect4.SelectByText("2025");
            Thread.Sleep(1000);

            var date = Driver.FindElement(By.XPath("//*[@id=\"ui-datepicker-div\"]/table/tbody/tr[3]/td[1]/a"));
            date.Click();


            var datepicker3 = Driver.FindElement(By.Id("start-date"));
            datepicker3.SendKeys("12122012");

            Thread.Sleep(1000);
            var datepicker4 = Driver.FindElement(By.Id("end-date"));
            datepicker4.SendKeys("12122014");

            Driver.FindElement(By.XPath("//button[@class='submit-btn']")).Click();

            Thread.Sleep(1000);
            js.ExecuteScript("window.scrollBy(0,950);");


            var uploadfile = Driver.FindElement(By.Id("singleFileInput"));
            uploadfile.SendKeys("C:\\Users\\DELL\\Desktop\\sakthibalagan.pdf");

            var uploadfile2 = Driver.FindElement(By.XPath("//*[@id=\"singleFileForm\"]/button"));
            uploadfile2.Click();
        }
    }
}
