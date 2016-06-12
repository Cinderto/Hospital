using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class Doctor : Person
    {
        public string Specialization { get; set; }
        public string Name { get; set; }


        public Doctor(string firstname, string surname, string address, string phonenumber,
            int numberOfSpecialization)
            : base(firstname, surname, address, phonenumber)
        {
            Name = firstname + " " + surname;
            Specialization = WhichSpecialization(numberOfSpecialization);
        }

        public override string ToString()
        {
            return Name;
        }

        private string WhichSpecialization(int numberOfSpecialization)
        {
            switch (numberOfSpecialization)
            {
                case (int)TypeOfSpecialization.Kardiolog:
                    return TypeOfSpecialization.Kardiolog.ToString();
                case (int)TypeOfSpecialization.Dermatolog:
                    return TypeOfSpecialization.Dermatolog.ToString();
                case (int)TypeOfSpecialization.Chirurg:
                    return TypeOfSpecialization.Chirurg.ToString();
                case (int)TypeOfSpecialization.Endokrynolog:
                    return TypeOfSpecialization.Endokrynolog.ToString();
                case (int)TypeOfSpecialization.Neurolog:
                    return TypeOfSpecialization.Neurolog.ToString();
                case (int)TypeOfSpecialization.Okulista:
                    return TypeOfSpecialization.Okulista.ToString();
                case (int)TypeOfSpecialization.Ortopeda:
                    return TypeOfSpecialization.Ortopeda.ToString();
                default:
                    return "";
            }
        }
    }
}

