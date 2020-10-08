using System.Configuration;
using System.Data.Entity;

namespace HospitalDb
{
    public class HospitalContext : DbContext
    {

        public HospitalContext() : base("HospitalDb")
        {

        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<LabLookup> LabLookups { get; set; }
        public DbSet<PatientLab> PatientLabs { get; set; }
        public DbSet<Country> Countries { get; set; }
    }
}
