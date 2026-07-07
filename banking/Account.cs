public delegate void AccountOperation();

public class Account
{
    private int balance;
    public event AccountOperation UnderBalance;
    public event AccountOperation OverBalance;

    public Account(int amount)
    {
        balance=amount;
    }

    public void Deposit(int amount)
    {
        balance+=amount;
        if (balance > 1000000)
        {
            OverBalance();
        }
    }

    public void Withdraw(int amount)
    {
        balance-=amount;
        if (balance < 5000)
        {
            UnderBalance();
        }
    }
}