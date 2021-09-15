using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomerData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData.Tests
{
    [TestClass()]
    public class CustomerTests
    {
        [TestMethod()]
        public void CalculateChargePositiveTest()
        {
            //arrange
            Customer cust = new Customer(1, "fname", "lname", 50m);
            decimal expectedBillamt = 15.50m;
            decimal actualBillamt;

            //act
            actualBillamt = cust.CalculateCharge();

            //assert
            Assert.AreEqual(expectedBillamt, actualBillamt);

        }

        [TestMethod()]
        public void CalculateChargeNegativeTest()
        {
            //arrange
            Customer cust = new Customer(1, "fname", "lname", -2m);
            decimal expectedBillamt = 12m;
            decimal actualBillamt;

            //act
            actualBillamt = cust.CalculateCharge();

            //assert
            Assert.AreEqual(expectedBillamt, actualBillamt);
        }

        [TestMethod()]
        public void CalculateChargeZeroTest()
        {
            //arrange
            Customer cust = new Customer(1, "fname", "lname", 0m);
            decimal expectedBillamt = 12m;
            decimal actualBillamt;

            //act
            actualBillamt = cust.CalculateCharge();

            //assert
            Assert.AreEqual(expectedBillamt, actualBillamt);
        }

    }
}