using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalculatorBl;

namespace CalculatorTest
{
    [TestClass]
    public class UnitTest1
    {

        //set up - prepare the object before unit testing
        Calculator calc = null;
        private TestContext testContext;
        //[TestInitialize]

        //public void SetUp()
        //{
        //    calc = new Calculator();
        //} 


        public TestContext TestContext { get => testContext; set=> testContext=value; }
        [TestInitialize]
        public void SetUp()
        {
            calc = new Calculator();
        }


        //TearDown - release/deallocate the object after testing
        //[TestCleanup]
        //public void TearDown()
        //{
        //    calc = null;
        //}



        [TestCleanup]
        public void TearDown()
        {
            calc = null;
        }
        
       
        [TestMethod]
        public void TestAddition()
        {
            //Calculator calc = new Calculator();

            // Assert class - used to perform unit testing, it will do assertion

            Assert.AreEqual(10,calc.Addition(6,4),"Addition failed!");
        }

        [TestMethod]
        public void TestCheckEven()
        {
            //Calculator calc = new Calculator();

            Assert.AreEqual(true, calc.CheckEven(2), "Number not even");
        }
        [TestMethod]
        public void TestCheckNotEven()
        {
            //Calculator cl = new Calculator();
            Assert.AreEqual(false, calc.CheckEven(3), "Number not odd");
        }
    }
}
