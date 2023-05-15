using System;


namespace Problem_11_Bank_Account_Data
{
class BankAccountData
{
    static void Main()
    {
        string firstName = "Angel";
        string middleName = "Staikov";
        string lastName = "Tosev";
        string bankName = "Bank";
        string iBAN = "ASDF132556GG2334566SD";
        decimal balance = 100000000000;
        ulong cardNumber1 = 1234567890987654;
        ulong cardNumber2 = 1234567890987654;
        ulong cardNumber3 = 1234567890987654;

        Console.WriteLine("First name: {0}\nMiddle name: {1}\nLast name: {2}\nBank name: {3}\nIBAN: {4}\nBalance: {5}\nCard number 1: {6}\nCard number 2: {7}\nCard Number 3: {8}",firstName,middleName,lastName,bankName,iBAN,balance,cardNumber1,cardNumber2,cardNumber3);

    }
}
}
