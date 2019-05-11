using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoItX3Lib;

namespace MarsFramework
{
    class Shareskill
    {
        public Shareskill()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        #region  Initialize Web Elements 
        //Click on Shareskill button
        [FindsBy(How = How.XPath, Using = "//a[text()='Share Skill']")]
        private IWebElement Shareskillbutton { get; set; }

        //Title
        [FindsBy(How = How.XPath, Using = "//input[@name='title']")]
        private IWebElement Title { get; set; }

        //Description
        [FindsBy(How = How.XPath, Using = "//textarea[@name='description']")]
        private IWebElement Description { get; set; }

        //Category
        [FindsBy(How = How.XPath, Using = "//select[@name='categoryId']")]
        private IWebElement Category { get; set; }

        //Select Category option "Music & Audio" option 5
        [FindsBy(How = How.XPath, Using = "//select[@name='categoryId']/option[@value]")]
        private IList <IWebElement> CategoryOption { get; set; }

        //SubCategory
        [FindsBy(How = How.XPath, Using = "//select[@name='subcategoryId']")]
        private IWebElement Subcategory { get; set; }

        //Select SubCategory option "Song Writers & Composers" option 3
        [FindsBy(How = How.XPath, Using = "//select[@name='subcategoryId']/option[@value]")]
        private IList<IWebElement> SubcategoryOption { get; set; }

        //Tag
        [FindsBy(How = How.XPath, Using = "//*[text()='Tags']//parent::div/following-sibling::div/div/div/div/div/input")]
        private IWebElement Tag { get; set; }

        //Hourly basis service
        [FindsBy(How = How.XPath, Using = "//input[@name ='serviceType' and @value = '0']")]
        private IWebElement HourlyBasisService { get; set; }

        //One-off service
        [FindsBy(How = How.XPath, Using = "//input[@name ='serviceType' and @value = '1']")]
        private IWebElement OneOffService { get; set; }

        //On-site
        [FindsBy(How = How.XPath, Using = "//input[@name ='locationType' and @value = '0']")]
        private IWebElement OnSite { get; set; }

        //Online
        [FindsBy(How = How.XPath, Using = "//input[@name ='locationType' and @value = '1']")]
        private IWebElement Online { get; set; }

        //Available days Start Dtae
        [FindsBy(How = How.XPath, Using ="//input[@name='startDate']")]
        private IWebElement startDate { get; set; }

        //Available days End Date
        [FindsBy(How = How.XPath, Using = "//input[@name='endDate']")]
        private IWebElement endDate { get; set; }

        //Available on Sunday
        [FindsBy(How= How.XPath, Using = "//input[@name= 'Available' and @index = '0']")]
        private IWebElement sunday { get; set; }

        //Available on Sunday StartTime
        [FindsBy(How = How.XPath, Using = "//input[@name= 'StartTime' and @index = '0']")]
        private IWebElement sunstarttime { get; set; }

        //Available on Sunday Endtime
        [FindsBy(How = How.XPath, Using = "//input[@name= 'EndTime' and @index = '0']")]
        private IWebElement sunendTime { get; set; }

        //Available on Monday
        [FindsBy(How = How.XPath, Using = "//input[@name= 'Available' and @index = '1']")]
        private IWebElement monday { get; set; }

        //Available on Monday StartTime
        [FindsBy(How = How.XPath, Using = "//input[@name= 'StartTime' and @index = '1']")]
        private IWebElement monstarttime { get; set; }

        //Available on Monday Endtime
        [FindsBy(How = How.XPath, Using = "//input[@name= 'EndTime' and @index = '1']")]
        private IWebElement monendTime { get; set; }

        //Available on Tuesday
        [FindsBy(How = How.XPath, Using = "//input[@name= 'Available' and @index = '2']")]
        private IWebElement tuesday { get; set; }

        //Available on Tuesday StartTime
        [FindsBy(How = How.XPath, Using = "//input[@name= 'StartTime' and @index = '2']")]
        private IWebElement tuestarttime { get; set; }

        //Available on Tuesday Endtime
        [FindsBy(How = How.XPath, Using = "//input[@name= 'EndTime' and @index = '2']")]
        private IWebElement tueendTime { get; set; }

        //Available on Wednesday
        [FindsBy(How = How.XPath, Using = "//input[@name= 'Available' and @index = '3']")]
        private IWebElement wednesday { get; set; }

        //Available on Wednesday StartTime
        [FindsBy(How = How.XPath, Using = "//input[@name= 'StartTime' and @index = '3']")]
        private IWebElement wedstarttime { get; set; }

        //Available on Wednesday Endtime
        [FindsBy(How = How.XPath, Using = "//input[@name= 'EndTime' and @index = '3']")]
        private IWebElement wedendTime { get; set; }

        //Available on Thursday
        [FindsBy(How = How.XPath, Using = "//input[@name= 'Available' and @index = '4']")]
        private IWebElement thursday { get; set; }

        //Available on Thursday StartTime
        [FindsBy(How = How.XPath, Using = "//input[@name= 'StartTime' and @index = '4']")]
        private IWebElement thustarttime { get; set; }

        //Available on Thursday Endtime
        [FindsBy(How = How.XPath, Using = "//input[@name= 'EndTime' and @index = '4']")]
        private IWebElement thuendTime { get; set; }

        //Available on Friday
        [FindsBy(How = How.XPath, Using = "//input[@name= 'Available' and @index = '5']")]
        private IWebElement friday { get; set; }

        //Available on Friday StartTime
        [FindsBy(How = How.XPath, Using = "//input[@name= 'StartTime' and @index = '5']")]
        private IWebElement fristarttime { get; set; }

        //Available on Friday Endtime
        [FindsBy(How = How.XPath, Using = "//input[@name= 'EndTime' and @index = '5']")]
        private IWebElement friendTime { get; set; }

        //Available on Saturday
        [FindsBy(How = How.XPath, Using = "//input[@name= 'Available' and @index = '6']")]
        private IWebElement saturday { get; set; }

        //Available on Saturday StartTime
        [FindsBy(How = How.XPath, Using = "//input[@name= 'StartTime' and @index = '6']")]
        private IWebElement satstarttime { get; set; }

        //Available on Saturday Endtime
        [FindsBy(How = How.XPath, Using = "//input[@name= 'EndTime' and @index = '6']")]
        private IWebElement satendTime { get; set; }

        //Skill-exchange radio button
        [FindsBy(How = How.XPath, Using = "//input[@name='skillTrades' and @value='true']")]
        private IWebElement skillExchange { get; set; }

        //Credit radio button
        [FindsBy(How = How.XPath, Using = "//input[@name='skillTrades' and @value='false']")]
        private IWebElement credit { get; set; }

        //Skill-Exchange tag
        [FindsBy(How = How.XPath, Using = "//*[text()='Skill-Exchange']//parent::div/following-sibling::div/div/div/div/div/div/input")]
        private IWebElement skillexchangetag { get; set; }

        //Credit Charge
        [FindsBy(How = How.XPath, Using = "//input[@name='charge']")]
        private IWebElement creditCharge { get; set; }

        //Work Samples
        [FindsBy(How = How.XPath, Using = "//div[@class ='ui grid']/span/i")]
        private IWebElement workSample { get; set; }

        //Active radio button
        [FindsBy(How = How.XPath, Using = "//input[@name='isActive' and @value='true']")]
        private IWebElement Active { get; set; }

        //Hidden radio button
        [FindsBy(How = How.XPath, Using = "//input[@name='isActive' and @value='false']")]
        private IWebElement Hidden { get; set; }

        //Save button
        [FindsBy(How = How.XPath, Using = "//input[@type='button' and @value='Save']")]
        private IWebElement Save { get; set; }

        //Cancel button
        [FindsBy(How = How.XPath, Using = "//input[@type='button' and @value='Cancel']")]
        private IWebElement Cancel { get; set; }

        //ManageLisiting Button
        [FindsBy(How = How.XPath, Using = "//a[@href='/Home/ListingManagement']")]
        private IWebElement ManagelistingButton { get; set; }

        //ManageListing Number of records
        [FindsBy(How= How.XPath, Using = "//table[@class='ui striped table']/tbody/tr/td[3]")]
        private IList <IWebElement> Numrecords { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='user-info']")]
        private IList<IWebElement> UserInfo { get; set; }

        //ManageListing number of pages
        [FindsBy(How = How.XPath, Using = "//button[@class = 'ui button otherPage']")]
        private IList <IWebElement> NumofPages { get; set; }

        //ManageListing number of pages
        [FindsBy(How = How.XPath, Using = "//button[@class = 'ui button otherPage' and text()='>']")]
        private IWebElement Nextpage { get; set; }

        //ManageListing View Eye
        [FindsBy(How = How.XPath, Using = "//table [@class='ui striped table']/tbody/tr/td[8]/i[@class = 'eye icon']")]
        private  IList <IWebElement> Eye { get; set; }

        //ManageListing Remove Eye(Delete)
        [FindsBy(How = How.XPath, Using = "//table [@class='ui striped table']/tbody/tr/td[8]/i[@class = 'remove icon']")]
        private IList<IWebElement> DeleteEye { get; set; }

        //Confirm Delete
        [FindsBy(How = How.XPath, Using = "//button[@class ='ui icon positive right labeled button']")]
        private IWebElement ConfirmDelete { get; set; }





        #endregion

        public void ShareskillListings()
        {
            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
            Thread.Sleep(1000);

            //Click on Share Skill Button
            Shareskillbutton.Click();
            Thread.Sleep(1000);

            //Enter the Details
            //Enter Title from Excel Sheet
            Title.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Title"));
            Thread.Sleep(1000);

            //Enter Description from Excel Sheet
            Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Description"));
            Thread.Sleep(1000);

            //Click on Category dropdown box
            Category.Click();
            Thread.Sleep(1000);
            //Select cartegory option from excel sheet by iterating the list of elements
            //I have declared CategoryOption as a IList<Iwebelement>
            int count = CategoryOption.Count;
            for (int i = 0; i < count; i++)
            {

                if (CategoryOption[i].Text == GlobalDefinitions.ExcelLib.ReadData(2, "CategoryOption"))
                {
                    CategoryOption[i].Click();

                }
            }

            Thread.Sleep(500);

            //Click on subcategory drop down box
            Subcategory.Click();
            Thread.Sleep(1000);

            //Click on 3 option from the dropdown
            int countsubcat = SubcategoryOption.Count;
            for (int i = 0; i < countsubcat; i++)
            {

                if (SubcategoryOption[i].Text == GlobalDefinitions.ExcelLib.ReadData(2, "SubCategoryOption"))
                {
                    SubcategoryOption[i].Click();

                }
            }
            Thread.Sleep(500);

            //Enter Tag from the Excel sheet
            Tag.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Tags"));
            Thread.Sleep(500);
            Tag.SendKeys(Keys.Enter);

            //Service Type as One-off service
            if (GlobalDefinitions.ExcelLib.ReadData(2, "ServiceType") == "Oneoff service")
            {
                OneOffService.Click();
            }
            else
            {
                HourlyBasisService.Click();
            }
            Thread.Sleep(500);

            //Location Type as On-site
            if (GlobalDefinitions.ExcelLib.ReadData(2, "LocationType") == "Onsite")
            {
                OnSite.Click();
            }
            else
            {
                Online.Click();
            }
            Thread.Sleep(500);

            //Enter Strt and End dates of Available days
            startDate.Click();
            Thread.Sleep(500);
            startDate.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "StartDate"));
            Thread.Sleep(500);
            endDate.Click();
            endDate.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "EndDate"));
            Thread.Sleep(500);

            //Enter the Available days and their Start and End Time from the Excel Sheet
            String availabledays = GlobalDefinitions.ExcelLib.ReadData(2, "Available");
            String starttimes = GlobalDefinitions.ExcelLib.ReadData(2, "StartTime");
            String endtimes = GlobalDefinitions.ExcelLib.ReadData(2, "EndTime");

            String[] availabledaysarray = new String[] { };
            availabledaysarray = availabledays.Split(',');
            int arraycount = availabledaysarray.Count();

            String[] starttimesarray = new String[] { };
            starttimesarray = starttimes.Split(',');
            int starttimecount = starttimesarray.Count();


            String[] endtimesarray = new String[] { };
            endtimesarray = endtimes.Split(',');
            int endtimecount = endtimesarray.Count();

            for (int i = 0; i < arraycount; i++)
            {
                switch (availabledaysarray[i])
                {
                    case "sun":
                        sunday.Click();
                        sunstarttime.SendKeys(starttimesarray[i]);
                        sunendTime.SendKeys(endtimesarray[i]);
                        break;

                    case "mon":
                        monday.Click();
                        monstarttime.SendKeys(starttimesarray[i]);
                        monendTime.SendKeys(endtimesarray[i]);
                        break;

                    case "tue":
                        tuesday.Click();
                        tuestarttime.SendKeys(starttimesarray[i]);
                        tueendTime.SendKeys(endtimesarray[i]);
                        break;

                    case "wed":
                        wednesday.Click();
                        wedstarttime.SendKeys(starttimesarray[i]);
                        wedendTime.SendKeys(endtimesarray[i]);
                        break;

                    case "thu":
                        thursday.Click();
                        thustarttime.SendKeys(starttimesarray[i]);
                        thuendTime.SendKeys(endtimesarray[i]);
                        break;

                    case "fri":
                        friday.Click();
                        fristarttime.SendKeys(starttimesarray[i]);
                        friendTime.SendKeys(endtimesarray[i]);
                        break;

                    case "sat":
                        saturday.Click();
                        satstarttime.SendKeys(starttimesarray[i]);
                        satendTime.SendKeys(endtimesarray[i]);
                        break;
                }
            }

            //Skill Trade as Credit/SkillExchange
            if (GlobalDefinitions.ExcelLib.ReadData(2, "SkillTrade") == "Credit")
            {
                credit.Click();
                Thread.Sleep(500);
                //Credit charge as 6 per hour from Excel sheet
                creditCharge.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "CreditCharges"));
                Thread.Sleep(500);
            }
            else
            {
                skillExchange.Click();
                Thread.Sleep(500);
                skillexchangetag.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "SkillExchangetag"));
                Thread.Sleep(500);
            }

            //Work samples
            workSample.Click();
            AutoItX3 autolt = new AutoItX3();
            autolt.WinActivate("Open");
            autolt.Send(GlobalDefinitions.ExcelLib.ReadData(2, "WorkSample"));
            //autolt.Send(@"E:\Competition Task1\Mars Automation framework\MarsFramework\MarsFramework\Empty.docx");
            Thread.Sleep(1000);
            autolt.Send("{ENTER}");


            //Set Active as Hidden/Active
            if (GlobalDefinitions.ExcelLib.ReadData(2, "ActiveService") == "Hidden")
            {
                Hidden.Click();
            }
            else
            {
                Active.Click();
            }

            //Save the form
            Save.Click();
            Thread.Sleep(1000);

        }

        public void ManageListingsServiceDetails()
        {
            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
            Thread.Sleep(1000);

            ManagelistingButton.Click();
            Thread.Sleep(1000);
            int records = Numrecords.Count;
            bool foundrecord = false;
            try
            {
                for (int p = 1; p <= NumofPages.Count; p++)
                {
                    for (int i = 0; i < records; i++)
                    {
                        Thread.Sleep(1000);

                        if (Numrecords[i].Text == (GlobalDefinitions.ExcelLib.ReadData(2, "Title")))
                        {
                            Thread.Sleep(2000);
                            Eye[i].Click();
                            foundrecord = true;
                            break;
                        }

                    }
                    if (foundrecord == false)
                    {
                        Nextpage.Click();
                        Thread.Sleep(5000);
                    }
                    else
                    {
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Could not find the record specified");

            }
                
        }

        public void ManageListingsDeleteDetails()
        {
            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
            Thread.Sleep(1000);

            ManagelistingButton.Click();
            Thread.Sleep(1000);
            int rec = Numrecords.Count;
            bool recfound = false;
            try
            {
                for (int g = 1; g <= NumofPages.Count; g++)
                {
                    for (int j = 0; j < rec; j++)
                    {
                        Thread.Sleep(1000);
                        
                        if (Numrecords[j].Text == (GlobalDefinitions.ExcelLib.ReadData(2, "Title")))                        
                        {
                            Thread.Sleep(2000);
                            DeleteEye[j].Click();
                            Thread.Sleep(2000);
                            ConfirmDelete.Click();
                            Thread.Sleep(2000);
                            recfound = true;
                            break;
                        }

                    }
                    if (recfound == false)
                    {
                        Nextpage.Click();
                        Thread.Sleep(5000);
                    }
                    else
                    {
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Could not find the record specified");

            }

        }




    }
        
    
}

