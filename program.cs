
// Console.WriteLine("Hello, World!");

BankAccount newaccount = new BankAccount();

if (newaccount.typeOfAccount == "checking")
{
    // balance = balance + 100;
    newaccount.balance += 100;
}
Console.WriteLine(newaccount.customerName + "'s balance is $" + newaccount.balance);

// int balance2 = 300;
// Console.WriteLine(balance2);

// float balance1 = 300.01f;
// Console.WriteLine(balance1);
