using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class HourlyEmployee : Employee  //ES: requires being public so other classes can access info
    {
        public decimal HourlyRate { get; set; }

        public HourlyEmployee() : base() //ES: logic error...needs to inherit the default base constructor 
        {
            HourlyRate = 0.0M; //ES: adding in hourly rate to the rest of the base class constructor
        }

        public HourlyEmployee(string firstName, string lastName, decimal hourlyRate, string phone, string email) //ES: logic error, cannot initialize here
            :base(firstName,lastName, phone, email)
        {
            HourlyRate = hourlyRate;
        }

        public override string PaySummary    //ES: logic error...needed key word override so it will 'override' the base string with this one
        {
            get 
            {
                return "This employee is payed " + HourlyRate + " per hour"; 
            }
        }

        public override decimal Pay(int start, int end)
        {
            decimal  hours = 0; 
            for(int day = start; day < end; ++day)
            {
                hours += Hours[day];
            }
            return hours * HourlyRate;
        }

        public override string ToString()
        {
            return base.ToString() + " Hourly Employee";
        }
    }
}
