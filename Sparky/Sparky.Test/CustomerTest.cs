using System;
using NUnit.Framework;

namespace Sparky.Test
{
    [TestFixture]
    public class CustomerTest
    {
        private Customer customer;

        [SetUp]
        public void Setup()
        {
            customer = new Customer();
        }

        [Test]
        public void CombineNames_InputFirstAndLastName_ReturnFullName()
        {
            // Arrenge

            // Act
            string fullName = customer.CombineNames("Adriano", "Santana");
            // Assert
            Assert.That(fullName, Is.EqualTo("Adriano Santana"));
        }

        [Test]
        public void GreetMessage_NotGreeted_ReturnsNull()
        {
            Assert.IsNull(customer.GreetMessage);
        }

        [Test]
        public void DiscountCheck_DefaultCustomer_ReturnDiscountInRange()
        {
            Assert.That(customer.Discount, Is.InRange(10, 25));
        }

        [Test]
        public void GreetMessage_GreetedWithoutLastName_ReturnsNotNull()
        {
            customer.GreetAndCombineNames("Adriano", "");
            Assert.IsNotNull(customer.GreetMessage);
            Assert.IsFalse(string.IsNullOrEmpty(customer.GreetMessage));
        }

        [Test]
        public void GreetChecker_EmptyFirstName_ThrowException()
        {
            // Forma 1
            var exceptionDetails = Assert.Throws<ArgumentException>(
                () => customer.GreetAndCombineNames("", "Santana")
            );
            Assert.AreEqual("Empty First Name", exceptionDetails.Message);

            // Forma 2
            Assert.That(
                () => customer.GreetAndCombineNames("", "Santana"),
                Throws.ArgumentException.With.Message.EqualTo("Empty First Name")
            );

            
            Assert.Throws<ArgumentException>(
                () => customer.GreetAndCombineNames("", "Santana")
            );

             Assert.That(
                () => customer.GreetAndCombineNames("", "Santana"),
                Throws.ArgumentException
            );
        }

        [Test]
        public void CustomerType_CreateCustomerWithLessThan100Order_ReturnBasicCustomer()
        {
            customer.OrderTotal = 10;
            var result = customer.GetCustomerDetails();
            Assert.That(result, Is.TypeOf<BasicCustomer>());
        }

        [Test]
        public void CustomerType_CreateCustomerWithMoreThan100Order_ReturnBasicCustomer()
        {
            customer.OrderTotal = 1000;
            var result = customer.GetCustomerDetails();
            Assert.That(result, Is.TypeOf<PlatinumCustomer>());
        }
    }
}
