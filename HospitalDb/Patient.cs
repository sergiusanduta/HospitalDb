using System;
using System.Collections.Generic;

namespace HospitalDb
{

    public class Patient
    {
        

        public Patient()
        {
            PatientLabs = new List<PatientLab>();
            PatientAddresses = new List<PatientAddress>();

        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirh { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsActive { get; set; }




        public virtual List<PatientLab> PatientLabs { get; set; }
        public virtual List<PatientAddress> PatientAddresses{ get; set; }
        public DateTime DateOfBirth { get; internal set; }
    }
}
