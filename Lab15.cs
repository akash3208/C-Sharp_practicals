using System;

class Account
{
    public int accNo;
    public string name;
    public double balance;

    public Account() {}

    public Account(int accNo, string name, double balance)
    {
        this.accNo = accNo;
        this.name = name;
        this.balance = balance;
    }

    public virtual void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine("Deposited: " + amount);
    }

    public virtual void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine("Withdrawn: " + amount);
        }
        else
        {
            Console.WriteLine("Insufficient Balance");
        }
    }

    public void Display()
    {
        Console.WriteLine("Account No: " + accNo);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Balance: " + balance);
    }
}

class SavingsAccount : Account
{
    public double interestRate;

    public SavingsAccount(int accNo, string name, double balance, double interestRate)
        : base(accNo, name, balance)
    {
        this.interestRate = interestRate;
    }

    public void AddInterest()
    {
        double interest = balance * interestRate / 100;
        balance += interest;
        Console.WriteLine("Interest Added: " + interest);
    }

    public override void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine("Withdrawn from Savings: " + amount);
        }
        else
        {
            Console.WriteLine("Insufficient Balance in Savings");
        }
    }
}

class CurrentAccount : Account
{
    public double overdraftLimit;

    public CurrentAccount(int accNo, string name, double balance, double overdraftLimit)
        : base(accNo, name, balance)
    {
        this.overdraftLimit = overdraftLimit;
    }

    public override void Withdraw(double amount)
    {
        if (amount <= balance + overdraftLimit)
        {
            balance -= amount;
            Console.WriteLine("Withdrawn from Current: " + amount);
        }
        else
        {
            Console.WriteLine("Overdraft limit exceeded");
        }
    }
}

class Program
{
    static void Main()
    {
        SavingsAccount sa = new SavingsAccount(101, "Akash", 5000, 5);
        sa.Deposit(1000);
        sa.AddInterest();
        sa.Withdraw(2000);
        sa.Display();

        Console.WriteLine();

        CurrentAccount ca = new CurrentAccount(102, "Ravi", 3000, 2000);
        ca.Deposit(500);
        ca.Withdraw(4500);
        ca.Display();
    }
}