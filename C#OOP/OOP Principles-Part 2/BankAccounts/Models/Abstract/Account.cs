namespace BankAccounts
{
    using BankAccounts.Models;
    using System;

    public abstract class Account
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;

        public Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customer Customer
        {
            get { return this.customer; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Customer cannot be null!");
                }
                else
                {
                    this.customer = value;
                }
            }
        }

        public decimal Balance
        {
            get { return this.balance; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Balance cannot be a negative value!");
                }
                else
                {
                    this.balance = value;
                }
            }
        }

        public decimal InterestRate
        {
            get { return this.interestRate; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Interest Rate cannot be negative value!");
                }
                else
                {
                    this.interestRate = value;
                }
            }
        }

        public virtual decimal InterestAmount(int numberOfMonths)
        {
            decimal result = numberOfMonths * this.InterestRate;
            return result;
        }
    }
}
