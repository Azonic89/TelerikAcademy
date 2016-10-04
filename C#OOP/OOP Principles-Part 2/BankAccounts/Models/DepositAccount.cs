namespace BankAccounts.Models
{
    using BankAccounts.Interfaces;
    using System;

    public class DepositAccount : Account, IDepositable, IWithDrawlable
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate) 
            : base(customer, balance, interestRate)
        {
        }

        public void Deposit(decimal depositMoney)
        {
            if (depositMoney <= 0)
            {
                throw new ArgumentException("Deposit Money cannot be a negative value");
            }
            else
            {
                this.Balance += depositMoney;
            }
        }

        public void Withdraw(decimal withdrawMoney)
        {
            if (withdrawMoney <= 0)
            {
                throw new ArgumentException("Withdraw Money cannot be negative or zero value!");
            }
            else if (this.Balance <= withdrawMoney)
            {
                throw new ArgumentException("Withdraw Ammount cannot be more than ur current balance!");
            }
            else
            {
                this.Balance -= withdrawMoney;
            }
        }

        public override decimal InterestAmount(int numberOfMonths)
        {
            if (base.Balance >= 0 && base.Balance <= 1000)
            {
                return 0;
            }
            else if (base.Balance > 1000)
            {
                return numberOfMonths * base.InterestRate;
            }
            else
            {
                throw new ArgumentException("Balance cannot be negative!");
            }
        }
    }
}
