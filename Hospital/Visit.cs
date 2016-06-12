using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class Visit
    {
        public string Hour { get; set; }
        public string Date { get; set; }
        public Doctor Doctor { get; set; }
        public Person Patient { get; set; }


        public Visit(Person nPatient, string nHour, string nDate, Doctor nDoctor)
        {
            Exception BadValue = new Exception("Nie można dodać wizyty, ponieważ nie wybrano lekarza");
            Patient = nPatient;
            if (nDoctor != null)
            {
                Doctor = nDoctor;
            }
            else
            {
                throw BadValue;
            }
            Hour = nHour;
            Date = nDate;
        }
    }
}
