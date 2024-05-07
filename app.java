public class BankAccount {
  private String accountNumber;
  private double balance;

  public BankAccount(String accountNumber, double initialBalance) {
      this.accountNumber = accountNumber;
      this.balance = initialBalance;
  }

  public void deposit(double amount) {
      if (amount > 0) {
          balance += amount;
          System.out.println(amount + " deposited. New balance: " + balance);
      } else {
          System.out.println("Invalid amount for deposit.");
      }
  }

  public void withdraw(double amount) {
      if (amount > 0 && balance >= amount) {
          balance -= amount;
          System.out.println(amount + " withdrawn. New balance: " + balance);
      } else {
          System.out.println("Insufficient funds or invalid amount for withdrawal.");
      }
  }

  public void displayBalance() {
      System.out.println("Current balance: " + balance);
  }

  public static void main(String[] args) {
      BankAccount account = new BankAccount("123456789", 1000.0);
      
      account.displayBalance();
      account.deposit(500.0);
      account.withdraw(200.0);
      account.displayBalance();
  }
}