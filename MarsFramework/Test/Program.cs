using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsFramework
{
    public class Program
    {
        [TestFixture]
        [Category("Sprint1")]
        class Tenant : Global.Base
        {

            [Test]
            public void UserAccount()
            {
                // Creates a toggle for the given test, adds all log events under it    
                test = extent.StartTest("Search for a Property");

                // Create an class and object to call the method
                Profile obj = new Profile();
                obj.EditProfile();

            }

            [Test]
            public void ShareskillDetails()
            {
                test = extent.StartTest("Skill share details");
                Shareskill obj = new Shareskill();
                obj.ShareskillListings();
                try
                {
                    Assert.AreEqual("ListingManagement", Global.GlobalDefinitions.driver.Title);
                    test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Skill Share Details Saved Successfully");
                }
                catch(Exception e)
                {
                    Console.WriteLine("You are on the Wrong Page");
                    test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Details of Share skill are not saved correctly");
                }

                
            }

            [Test]
            public void ShareskillViewDetails()
            {
                test = extent.StartTest("Skill share view details from Manage Listing");
                Shareskill obj = new Shareskill();
                obj.ManageListingsServiceDetails();
                try
                {
                    Assert.AreEqual("Service Detail", Global.GlobalDefinitions.driver.Title);
                    test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Found the Record and could view the details successfully");
                }
                catch (Exception e)
                {
                    Console.WriteLine("You are on the Wrong Page");
                    test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Could not get the details of the specific record");
                }


            }

            [Test]
            public void ShareskillDeleteDetails()
            {
                test = extent.StartTest("Skill share Delete record details");
                Shareskill obj = new Shareskill();
                obj.ManageListingsDeleteDetails();
                try
                {
                    Assert.AreEqual("ListingManagement", Global.GlobalDefinitions.driver.Title);
                    test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Skill Share Details were Deleted Successfully");
                }
                catch (Exception e)
                {
                    Console.WriteLine("You are on the Wrong Page");
                    test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Details of Share skill are not deleted");
                }


            }
        }
    }
}