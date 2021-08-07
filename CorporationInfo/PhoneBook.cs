using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class PhoneBook 
    {
        public List<PhoneBookItem> phoneBookEntries = new List<PhoneBookItem>();
        public List<PhoneBookItem> PhoneBookEntries
        {
            get { return phoneBookEntries; }
            set { phoneBookEntries = value; GetPhoneBook(); } //ES: call GPB method
        }

        public PhoneBook()
        {
        }

        public virtual string GetPhoneBook()
        {
            string phonebook = "";
            //foreach (string item in PhoneBookEntries)  
            //{
            //    phonebook += item.GetContactSummary() + "\n\n";
            //}
            for (int i = 0; i < PhoneBookEntries.Count; ++i)  //ES: rewrote loop, its easier for me to understand 
            {
                string entry = PhoneBookEntries[i].GetContactSummary();
                phonebook += entry + "\n\n";
            }
            return phonebook;
        }
    }
}
