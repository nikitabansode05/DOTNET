using banking.listner;
using banking.service;

Notification message=new SMS();
Account account=new AccountImpl(9000,message);


account.withdraw(800);
account.deposit(900);