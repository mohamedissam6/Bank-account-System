using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    internal abstract class employee
    {
        private string Name;
        public string name { get { return Name; } set { Name = value; } }
         public employee(string name)
        {
            Name = name;
        }
        public abstract double earning();

    }
}
