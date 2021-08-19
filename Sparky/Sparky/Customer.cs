using System;

namespace Sparky
{
    public class Customer
    {
        public int Discount { get; set; }
        public int OrderTotal { get; set; }
        public string GreetMessage { get; set; }

        public Customer()
        {
            Discount = 10;
        }
        
        public string CombineNames(string firstName, string lastName)
        {
            return $"{firstName} {lastName}";
        }

        public string GreetAndCombineNames(string firstName, string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
            {
                throw new ArgumentException("Empty First Name");
            }
            GreetMessage = $"Hello, {firstName} {lastName}";
            Discount += 5;
            return GreetMessage;
        }

        public CustomerType GetCustomerDetails()
        {
            if (OrderTotal < 100)
            {
                return new BasicCustomer();
            }
            return new PlatinumCustomer();
        }
    }

    public class CustomerType {}
    public class BasicCustomer: CustomerType {}
    public class PlatinumCustomer: CustomerType {}
}
