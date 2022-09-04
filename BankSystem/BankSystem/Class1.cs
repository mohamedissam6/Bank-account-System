using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    internal class Accounts
    {
        private int AccountNum;
        private string Name;
        private double Balance;
        private decimal Age;
        

        public int accountNum
        {
            get { return accountNum; }
        }
        public decimal age { get { return Age;} set{Age = value; }}
        public string name { get { return Name; } set { Name = value; } }
        public double balance { get { return Balance; } set { if (value>0) Balance = value; } }

        public Accounts() { }
        public Accounts(string name,double balance,decimal age)
        {
            Name = name;
            Balance = balance;
            Age = age;
            Random random = new Random();
            AccountNum = random.Next(100000000,999999999);
            

        }
        public virtual void Deposit(double amount)
        {
            if (amount > 0) { Balance = Balance + amount; }
            
            
        }
        public virtual void Withdraw(double amount)
        {
            if (amount > 0 && Balance > amount) { Balance = Balance - amount; }
            
            
        }
       
        public override string ToString()
        {
            return ($"Account number : {AccountNum} \tName : {Name}\t Starting Balance : {Balance}\t");
        }
    }
}
