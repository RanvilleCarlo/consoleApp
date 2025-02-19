//encapsulation
using ConsoleApp1.src.oops.encapsulation;

BankAccount bankAccount = new BankAccount(100);
System.Console.WriteLine(bankAccount.GetBalance());

bankAccount.Deposit(50);
System.Console.WriteLine(bankAccount.GetBalance());

bankAccount.Withdraw(20);
System.Console.WriteLine(bankAccount.GetBalance()); 