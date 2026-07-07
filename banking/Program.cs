public class Program
{
    public static void Main()
    {
        Account myAccount=new Account(10000);

        myAccount.UnderBalance+=PayPenalty;
        myAccount.UnderBalance+=BlockBankAccount;
        myAccount.OverBalance+=PayIncomeTax;
        myAccount.OverBalance+=PayProfessionalTax;

        myAccount.Deposit(2000000);
    }

    public static void PayPenalty()
    {
        Console.WriteLine("⚠️ Pay ₹500 penalty within 15 days.");
    }

    public static void BlockBankAccount()
    {
        Console.WriteLine("🚫 Your account has been blocked.");
    }

    public static void PayIncomeTax()
    {
        Console.WriteLine("💰 Please pay applicable Income Tax.");
    }

    public static void PayProfessionalTax()
    {
        Console.WriteLine("🧾 Professional Tax due this quarter.");
    }
}