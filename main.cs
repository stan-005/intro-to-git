using System;

public class BankAccount
{
    private string accountNumber;
    private double balance;

    public BankAccount(string accountNumber, double initialBalance)
    {
        this.accountNumber = accountNumber;
        this.balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"{amount} deposited. New balance: {balance}");
        }
        else
        {
            Console.WriteLine("Invalid amount for deposit.");
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && balance >= amount)
        {
            balance -= amount;
            Console.WriteLine($"{amount} withdrawn. New balance: {balance}");
        }
        else
        {
            Console.WriteLine("Insufficient funds or invalid amount for withdrawal.");
        }
    }

    public void DisplayBalance()
    {
        Console.WriteLine($"Current balance: {balance}");
    }

    public static void Main(string[] args)
    {
        BankAccount account = new BankAccount("123456789", 1000.0);

        account.DisplayBalance();
        account.Deposit(500.0);
        account.Withdraw(200.0);
        account.DisplayBalance();
    }
}