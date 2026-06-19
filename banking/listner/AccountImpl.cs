using banking.service;

namespace banking.listner{
    public class AccountImpl :Account{

        private Notification notify;
        private double balance;

        public AccountImpl(){

        }

        public AccountImpl(double balance,Notification notify){
            this.balance=balance;
            this.notify=notify;
        }

        public void withdraw(double amount){
            balance-=amount;
            Console.WriteLine(balance);
            notify.send("The amount is withdrawed");
        }

        public void deposit(double amount){
            balance+=amount;
            Console.WriteLine(balance);
            notify.send("The amount is deposited");
        }
    }
}