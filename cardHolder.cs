using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class cardHolder
    {
        string cardNUm;
        int pin;
        string firstName;
        string lastName;
        double balance;

        public cardHolder(string cardNum,int pin,string firstName,string lastName,double balance)
        {
            this.cardNUm = cardNum;
            this.pin = pin;
            this.firstName = firstName;
            this.lastName = lastName;
            this.balance = balance;

        }

        public string getNum()
        {
            return cardNUm;
        }
        public void settNum(string newcardNUm)
        {
            cardNUm = newcardNUm;
        }

        public int getPin()
        {
            return pin;
        }
        public void setPin(int newPin)
        {
            pin = newPin;
        }

        public string getFirstName()
        {
            return firstName;
        }
        public void setFirstName(string newFirstName)
        {
            firstName = newFirstName;
        }

        public string getLastName()
        {
            return lastName;
        }
        public void setLastName(string newLastName)
        {
            lastName = newLastName;
        }

        public double getBalance()
        {
            return balance;
        }
        public void setBalance(double newBalance)
        {
            balance = newBalance;
        }
    }
}
