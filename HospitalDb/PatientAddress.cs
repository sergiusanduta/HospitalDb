using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDb
{
     public class PatientAddress
     {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public string Street { get; set; }
        public string Zip { get; set; }
        public string State { get; set; }
        public int CountryId { get; set; }

        public virtual Patient Patient { get; set; }
        public virtual Country Country { get; set; }

    }
}
