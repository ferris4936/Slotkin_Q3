using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public abstract class PhoneBookItem : Employee//ES: this is an abstract class that inherits the GetContactMethod() from Employee
    {
        //public string FirstName { get; set; } //ES: need the all properties to use in GetContactSummary() 
        //public string LastName { get; set; } //ES: need the all properties to use in GetContactSummary() 
        //public string Phone { get; set; } //ES: need the all properties to use in GetContactSummary() 
        //public string Email { get; set; } //ES: need the all properties to use in GetContactSummary() 

        public abstract override string GetContactSummary();    

    }  
}
