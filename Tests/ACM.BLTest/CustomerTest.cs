using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            // arrage
            Customer customer = new Customer();
            customer.FirstName = "Bilbo";
            customer.LastName = "Baggins";
            string expected = "Baggins, Bilbo";

            // act
            string actual = customer.FullName;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            // arrange
            Customer customer = new Customer
            {
                LastName = "Baggins"
            };
            string expected = "Baggins";

            // act
            string actual = customer.FullName;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullLastNameEmpty()
        {
            // arrange 
            Customer customer = new Customer
            {
                FirstName = "Bilbo"
            };
            string expected = "Biblo";

            // act
            string actual = customer.FullName;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            // arrange
            var c1 = new Customer();
            c1.FirstName = "Biblo";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Frodo";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Rosie";
            Customer.InstanceCount += 1;

            // act

            // assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }
    }

}
