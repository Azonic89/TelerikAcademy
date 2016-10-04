namespace BankAccounts.Models
{
    using BankAccounts.Enumerations;
    using System;

    public class Customer
    {
        private CustomerType customerType;
        private string fullName;
        private string address;
        private string phoneNumber;

        public Customer(CustomerType customerType, string fullName, string address, string phoneNumber)
        {
            this.CustomerType = customerType;
            this.FullName = fullName;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
        }

        public CustomerType CustomerType
        {
            get { return this.customerType; }
            set
            {
                this.customerType = value;
            }
        }

        public string FullName
        {
            get { return this.fullName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Customer Full Name cannot be a null value!");
                }
                else
                {
                    this.fullName = value;
                }
            }
        }

        public string Address
        {
            get { return this.address; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Customer Address cannot be a null value!");
                }
                else
                {
                    this.address = value;
                }
            }
        }

        public string PhoneNumber
        {
            get { return this.phoneNumber; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Customer Phone Number cannot be a null value!");
                }
                else
                {
                    this.phoneNumber = value;
                }
            }
        }
    }
}
