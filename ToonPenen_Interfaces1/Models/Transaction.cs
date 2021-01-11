using System;

namespace ToonPenen_Interfaces1.Models
{
    public class Transaction : Bank, ITransaction
    {
        private readonly string _code;
        private readonly string _date;
        private readonly double _amount;
        private double _commission;
        public Transaction(string code, string date, double amount)
        {
            string _code = code;
            string _date = date;
            double _amount = amount;
        }
        public double GetAmount()
        {
            
            if (_amount > 100)
            {
                _commission = (_amount * 0.50)/100;
                Console.WriteLine($"You will BE charged with an extra comission {_commission}");
                
                return _amount;
            }
            else
            {
                Console.WriteLine("Your account will NOT Be charged");
                
                return _amount;
            }
        }

        public string ShowBankName()
        {

            Console.WriteLine(BankName);
            return BankName;
        }

        public void ShowTransaction()
        {
            Console.WriteLine($"BANK {BankName} ADRESS {Address}");
            
            Console.WriteLine($"Transaction : {_code}");

            Console.WriteLine($"Date : {_date}");

            Console.WriteLine($"Amount :  {_amount}");
            GetAmount();
        }

    }
}
