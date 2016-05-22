using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A bank account has a holder name(first name, middle name and last name), available amount of money(balance), bank name,
//IBAN, 3 credit card numbers associated with the account.Declare the variables needed to keep the information
//for a single bank account using the appropriate data types and descriptive names.

namespace _11.BankAccountData
{
    class BankAccountData
    {
        static void Main(string[] args)
        {
            string FirstName = "Bob";
            string MiddleName = "Marley";
            string LastName = "Marley";
            decimal Balance = 12431212.414412M;
            string BankName = "DSK";
            object IBAN = "BGN12343";
            object BIC = "ASDSdc12344";
            ulong CreditCard1 = 1253212431512341231;
            ulong CreditCard2 = 124124125125412421;
            ulong CreditCard3 = 1234124124125412;

            Console.WriteLine("First Name: {0}\nMiddleName: {1}\nLast Name: {2}\nBalance: {3}\nBankname: {4}\nIBAN: {5}\nBIC:{6}\nCredit card1: {7}\nCredit card2: {8}\nCredit card3: {9}", FirstName, MiddleName, LastName, Balance,                 BankName,IBAN, BIC, CreditCard1, CreditCard2, CreditCard3);
        }
    }
}
