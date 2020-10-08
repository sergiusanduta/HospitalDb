using System.Collections.Generic;

namespace HospitalDb
{
    public class PatientLab
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int LabId { get; set; }
      
        public virtual Patient Patient { get; set; }
        public virtual LabLookup  Lab { get; set; }
    }
}
