using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Department //: PhoneBookItem //ES: Dept inherits nothing from PB
    {
        public Department(): this("TBD", null, "TBD", "TBD", "TBD", "TBD") //ES: initialize fields in the default constructor
        {
        }

        public Department(string name, Employee manager, string description, string phone, string email, string website) //ES: logic errorr...initialized in the default constructor
        {
            Name = name;
            Manager = manager;
            Description = description;
            Phone = phone;
            Email = email;
            Website = website;
        }
        public string Name { get; set; }

        public Employee Manager { get; set; }

        public string Description { get; set; }

        public string Phone { get; set; } //ES: inappropriate use of new!

        public string Email { get; set; }  //ES: inappropriate use of new!

        public string Website { get; set; }

        public string GetContactSummary() //ES: deleted new..this is just a class method in Dept, not same method as in Employee, not trying to override
        {
            return "Department: "+Name + "\n" +
                   Description+"\n"+
                   "Phone: " + Phone + "\n" +
                   "Email: " + Email + "\n" +
                   "Website: " + Website;
        }
    }
}
