using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class SalaryEmployee : Employee
    {
        public decimal Salary { get; set; }

        public SalaryEmployee() : base()
        {
            Salary = 0;
        }

        public SalaryEmployee(string firstName, string lastName, decimal salary, string phone, string email) : //ES: deleted bc all values are already inherited from the base
            base(firstName, lastName, phone, email)
        {
            Salary = salary;
        }

        public override string PaySummary
        {
            get
            {
                return "This employee is payed " + Salary + " per year";
            }
        }

        public override decimal Pay(int start, int end)
        {
            const int PAYPERIODSPERYEAR = 24; //ES: no error per se, common practice to uppercase all letters when declaring const
            decimal pay = Salary * (end - start) / PAYPERIODSPERYEAR;
            return pay;  
        }

        public new string ToString()
        {
            return base.ToString() + " Salary Employee";
        }
    }
}

