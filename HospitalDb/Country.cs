using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDb
{
    public class Country
    {
        public Country()
        {
            PatientAddresses = new List<PatientAddress>();
        }
        public int Id { get; set; }
        public string CountryName { get; set; }
        public virtual List<PatientAddress> PatientAddresses { get; set; } 
    }
}
