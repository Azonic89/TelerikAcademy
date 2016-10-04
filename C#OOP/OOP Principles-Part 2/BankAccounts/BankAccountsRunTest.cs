namespace BankAccounts
{
    using BankAccounts.Enumerations;
    using BankAccounts.Models;
    using System;

    public class BankAccountsRunTest
    {
        public static void Run()
        {
            Account[] depositAccount = new Account[]
            {
                new DepositAccount(new Customer(CustomerType.Individuals, "Stamat Sedefov", "Pernik", "0899115011"), 150M, 5M),
                new DepositAccount(new Customer(CustomerType.Companies, "Telus", "Sofia", "*88"), 100000M, 18M),
                new DepositAccount(new Customer(CustomerType.Companies, "Apple", "California, USA", "555-123-123"), 50000M, 3M)
            };

            Account[] loanAccont = new Account[]
            {
                new LoanAccount(new Customer(CustomerType.Companies, "Vivacom", "Sofia", "02/55113"), 400M, 1M),
                new LoanAccount(new Customer(CustomerType.Individuals, "Gosho Peshov", "Veliko Tarnovo", "033-12-3"), 1M, 2M),
                new LoanAccount(new Customer(CustomerType.Individuals, "Mariika Toshova", "Burgas", "044-22-4"), 155M, 11M)
            };

            Account[] mortgageAccount = new Account[]
            {
                new MortgageAccount(new Customer(CustomerType.Individuals, "Blagoy Berbatov", "London", "024-44-44"), 1500M, 10M),
                new MortgageAccount(new Customer(CustomerType.Individuals, "Qlo Yolov", "Burgas", "08855123"), 444M , 2M),
                new MortgageAccount(new Customer(CustomerType.Companies, "Vivacom", "Sofia", "011-23-3"), 111M , 1M)
            };

            Console.WriteLine("---------- Deposit accounts ----------");
            PrintAccounts.Print(depositAccount);

            Console.WriteLine("---------- Loan accounts ----------");
            PrintAccounts.Print(loanAccont);

            Console.WriteLine("---------- Mortgage accounts ----------");
            PrintAccounts.Print(mortgageAccount);

            Console.WriteLine("---------- Mitko deposit accounts ----------");
            DepositAccount mitkoDepositeAccount = new DepositAccount(new Customer(CustomerType.Individuals, "Mitko Mitkov", "Pleven", "044-2222-2"), 500M, 12M);
            mitkoDepositeAccount.Deposit(111M);
            mitkoDepositeAccount.Withdraw(11M);
            Console.WriteLine("Mitko balance: " + mitkoDepositeAccount.Balance);
            Console.WriteLine();

            Console.WriteLine("---------- Asus loan accounts ----------");
            LoanAccount asusLoanAccount = new LoanAccount(new Customer(CustomerType.Companies, "ASUS", "Taiwan", "000111"), 199900M, 14M);
            asusLoanAccount.Deposit(1313M);
            Console.WriteLine("ASUS balande: " + asusLoanAccount.Balance);
            Console.WriteLine();

            Console.WriteLine("---------- Lenovo mortgage accounts ----------");
            MortgageAccount lenovoMortgageAccount = new MortgageAccount(new Customer(CustomerType.Companies, "LENOVO", "China", "0991100"), 33333M, 100M);
            lenovoMortgageAccount.Deposit(10000M);
            Console.WriteLine("Lenovo balance: " + lenovoMortgageAccount.Balance);
            Console.WriteLine();
        }
    }
}
