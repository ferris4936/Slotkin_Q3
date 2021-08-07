using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{    
    public class Employee //: PhoneBookItem...Employee is the base class
    {
        private static int LastEmpNum = 0;
        public int EmpNum { get; set; } //ES: deleted private
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private List<decimal> hours = new List<decimal>();

        public List<decimal> Hours
        {
            get { return hours; }
            set { hours = value; }
        }

        public Employee() : this("TBD", "TBD", "TBD", "TBD") { }//ES: initialize fields in the default constructor

        public Employee(string firstName, string lastName, string phone, string email ) //ES: logic errorr...deleted phone = "TBD", email = "TBD", initialized in the default constructor
        {
            FirstName = firstName;
            LastName = lastName;
            EmpNum = LastEmpNum++;
            Phone = phone;
            Email = email;
        }

        public virtual string PaySummary
        {
            get { return "No pay for base class employee."; }
        }

        public virtual decimal Pay(int start, int end) //ES: logic error...need to create method in base class and set default value
        {
            return 0.0M;   
        }
        public override string ToString()
        {
            return EmpNum + " " + FirstName + " " + LastName;
        }

        public string Phone { get; set; }

        public string Email { get; set; }

        public virtual string GetContactSummary() //ES: logic error...method must be virtual to be called by other classes and altered
        {
            return FirstName + " " + LastName + "\n" +
                   "Phone: " + Phone + "\n" +
                   "Email: " + Email;
        }
    }
}
