using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class Person
    {
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public Person(string nFirstname, string nSurname, string nAddress, string nPhoneNumber)
        {
            Firstname = nFirstname;
            Surname = nSurname;
            Address = nAddress;
            PhoneNumber = nPhoneNumber;
        }

        public override string ToString()
        {
            return Firstname + " " + Surname + ", " + Address + ", tel. " + PhoneNumber;
        }
    }
}
