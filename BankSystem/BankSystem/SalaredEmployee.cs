using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    internal class SalaredEmployee : employee
    {
        private double weeks;
        public double Weeks { get { return weeks; } set { weeks = value; } }
        public SalaredEmployee(string name,double weeks) : base(name)
        {
            this.weeks = weeks;
        }
        public override double earning()
        {
            return weeks * 1000;
        }
    }
}
