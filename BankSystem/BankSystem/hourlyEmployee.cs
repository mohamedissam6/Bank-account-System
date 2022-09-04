using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    internal class hourlyEmployee : employee
    {
        private double hours;
        public double Hours { get { return hours; } set { hours = value; } }
        public hourlyEmployee(string name,double hours):base(name)
        {
            this.hours = hours;
        }
        public override double earning()
        {
            if (hours < 40) return hours * 10;
            else return (400 + (hours - 40) * 15);
        }
    }
}
