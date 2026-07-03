using System;

class Bank
{
    public string accountNumber;
    public string accountType;
    private double balance;

    public double Balance
    {
        get { return balance; }
    }

    public Bank(string accNum, string accType, double initialBalance)
    {
        accountNumber = accNum;
        accountType = accType;
        balance = initialBalance; 
    }

    public void Deposite(double amount)
    {
        balance += amount;
        Console.WriteLine($"Deposited {amount}. New balance: {balance}");
    }

    public void Withdraw(double amount)
    {
        if (amount > balance)
        {
            Console.WriteLine("Insufficient funds.");
        }
        else
        {
            balance -= amount;
            Console.WriteLine($"Withdrew {amount}. New balance: {balance}");
        }
    }

    public void SeeBalance()
    {
        Console.WriteLine($"Current balance: {balance}");
    }
}

class BankAccountManager
{
    static void Main(string[] args)
    {
        Bank myAccount1 = new Bank("123456789", "Savings", 1000.0);
        Bank myAccount2 = new Bank("987654321", "Current", 1000.0);

        myAccount1.Deposite(500.0);
        myAccount1.Withdraw(200.0);
        myAccount1.SeeBalance();

        myAccount2.Deposite(5000.0);
        myAccount2.Withdraw(2200.0);
        myAccount2.SeeBalance();

        Console.WriteLine();

        Bank[] accounts = new Bank[5];
        accounts[0] = new Bank("SB1001", "Savings", 5000);
        accounts[1] = new Bank("CA2002", "Current", 10000);
        accounts[2] = new Bank("SB1003", "Savings", 7500);
        accounts[3] = new Bank("SB1004", "Savings", 3200);
        accounts[4] = new Bank("CA2005", "Current", 15000);

        double total = 0;
        double highest = accounts[0].Balance;

        foreach (Bank acc in accounts)
        {
            double bal = acc.Balance;
            total += bal;

            if (bal > highest)
                highest = bal;
        }

        double average = total / accounts.Length;

        Console.WriteLine("Total balance: " + total);
        Console.WriteLine("Average balance: " + average);
        Console.WriteLine("Highest balance: " + highest);
    }
}