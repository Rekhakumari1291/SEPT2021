using August2021.Page;
using August2021.Pages;
using August2021.Utilites;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace August2021.Tests
{
    [TestFixture]
    [Parallelizable]
    class Employee_Tests : CommonDriver
    {


  [Test, Order(1)]
        public void CreateEmployeestest()
        {
            // Home page initialization and definition
            Homepage HomepageObj = new Homepage();
            HomepageObj.GoToTMPage(driver);

            
                // TM page initializatio and definiion
                Employeespage EmployeepageObj = new Employeespage();
                EmployeepageObj.CreateEmployee(driver);

            }
        
        [Test, Order(2)]
        public void EditEmployeesTest()
            {
              //  Home page initialization and definition
            Homepage HomepageObj = new Homepage();
                HomepageObj.GoToTMPage(driver);

            

            
            //Edit
            Employeespage EmployeepageObj = new Employeespage();
            EmployeepageObj.EditEmployee(driver);

        }
        [Test, Order(3)]
        //Delete
        public void DeleteEmployeeTest()
        {
             //Home page initialization and definition
            Homepage HomepageObj = new Homepage();
            HomepageObj.GoToTMPage(driver);

            Employeespage EmployeepageObj = new Employeespage();
            EmployeepageObj.DeleteEmployee(driver);
        }
        [TearDown]
        public void closeTestRun()
        {



        }
    }
}

    
    


    



    


