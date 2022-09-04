using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    internal class SavingAccount : Accounts
    {
        
        private double taxes;
        private double benefits;
        
        

        public SavingAccount(string name ,double balance, decimal age):base(name,balance,age)
        {
            taxes = 0.003;
            benefits = 0.075;
        }


        public void applytaxes()
        {
            balance -= taxes * balance;
        }
        public string tax()
        {
            double t = taxes * balance;
            return String.Format("{0:0.00}", t);
        }



        public void applybenefits()
        {
            balance += benefits * balance;
        }
        public string ben()
        {
            double t = benefits * balance;
            return String.Format("{0:0.00}", t);
        }

        public override string ToString()
        {
            return base.ToString() + "Saving account";
        }

    }
}
