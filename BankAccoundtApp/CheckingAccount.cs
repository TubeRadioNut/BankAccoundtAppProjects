using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccoundtApp
{
    internal class CheckingAccount
    {
        //fields
        Random random = new Random();
        private int _accountNumber;
        private decimal _balance;
        private string _bankName;


        //constructor:
        //it is a special method
        //has no return type
        //must have same name as class
        //purpose: initialize the private fields of an object
        public CheckingAccount(int accountNumber, decimal balance, string bankName) 
        {
            _accountNumber = accountNumber;
            _balance = balance;
            _bankName = bankName;
        }
        //default constructor: it is a constructor with no parameters
        public CheckingAccount()
        {
            _accountNumber = random.Next(1111111, 99999999);
            _balance = 100;
            _bankName = "Bank of America";
        }
        //properites
        //we should be able to access private fields in Form1
        //we use properites to provide controlled access
        //2 accessors: get and set

        //convention: capitalixe the frist letter of a property name
        //must be public
        public int AccountNumber
        {
            get { return _accountNumber; }
        }
        public decimal Balance
        {
            get { return _balance; }
        }
        public string BankName
        {
            get { return _bankName; }
        }

        //Method: Deposit, Withdraw
        public void Deposit(decimal amount)
        {
            _balance += amount;
        }
        public bool Withdraw(decimal amount)
        {
            //if(amount > _balance) 
            //    return false;
            //_balance -= amount;
            //return true;

            if(_balance > amount)
            {
                _balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        //Use the ToString() ---> override it
        public override string ToString()
        {
            string result = String.Format($"{_bankName,-25}{_accountNumber,-15} {_balance:c}");
            return result;
        }
    }
}
