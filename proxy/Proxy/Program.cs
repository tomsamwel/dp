using Proxy;

string user1 = "Casper";
string user2 = "Stanislav";
IBackAccount BankAccountUser1 = new AccessProxy( new BankAccount(), user1);
IBackAccount BankAccountUser1Insecure = new BankAccount();
IBackAccount BankAccountUser2 = new AccessProxy( new BankAccount(), user2);
Console.WriteLine("With user 2:");
Console.Write("Balance of user 2: "); // access
Console.WriteLine(BankAccountUser2.CheckBalance(user2)); // access
try
{
    Console.Write("Balance of user 1: ");
    Console.WriteLine(BankAccountUser1.CheckBalance(user2)); // access denied
}
catch (AccessDeniedException){}
Console.Write("Balance of user 1 (insecure): "); // access granted
Console.WriteLine(BankAccountUser1Insecure.CheckBalance(user2)); // access granted
System.Console.ReadLine();
