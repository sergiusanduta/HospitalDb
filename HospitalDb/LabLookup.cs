using System.Collections.Generic;

namespace HospitalDb
{
    public class LabLookup
    {
        public LabLookup()
        {
            PatientLabs = new List<PatientLab>();
        }
        public int Id { get; set; }
        public string LabName { get; set; }

        public virtual List<PatientLab> PatientLabs { get; set; }

    }
}
