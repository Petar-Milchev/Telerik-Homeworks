using System;

    class BankAccountData
    {
        static void Main(string[] args)
        {
            string firstName = "Plamen";
            string middleName = "Ivanov";
            string lastName = "Todorov";
            decimal balance = 57.300M;
            string bankName = "First Investment Bank";
            string IBAN = "39FINV91501003548797";
            long firstCreditCard = 2332475699810271;
            long secondCreditCard = 9876543217654322;
            long thirdCreditCard = 6547368543437685;

            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}\n{7}\n{8}",
                firstName, middleName, lastName, balance, bankName, IBAN, firstCreditCard, secondCreditCard, thirdCreditCard);
        }
    }

