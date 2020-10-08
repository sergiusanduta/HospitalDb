using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalDb
{
    class Program
    {
        static void Main(string[] args)
        {
            using (HospitalContext db = new HospitalContext())
            {
                Patient patient = new Patient();
                patient.LastName = "Doe";
                patient.FirstName = "John";
                patient.DateOfBirh = new System.DateTime(2000, 12, 1);
                patient.DateCreated = DateTime.Now;
                patient.IsActive = true;
                db.Patients.Add(patient);
                db.SaveChanges();

                Patient patient2 = new Patient();
                patient.LastName = "Arnold";
                patient.FirstName = "Schwarzenegger";
                patient.DateOfBirth = new System.DateTime(1949, 1, 2);
                patient.DateCreated = DateTime.Now;
                patient.IsActive = true;
                db.Patients.Add(patient2);
                db.SaveChanges();

                List<LabLookup> labs = new List<LabLookup>();
                labs.Add(new LabLookup { LabName = "Covid-19" });
                labs.Add(new LabLookup { LabName = "MRI" });
                labs.Add(new LabLookup { LabName = "Cholesterol test" });
                labs.Add(new LabLookup { LabName = "Vitamin B-12" });

                db.LabLookups.AddRange(labs);
                db.SaveChanges();

                PatientLab patientLab1 = new PatientLab();
                patientLab1.PatientId = 1;
                patientLab1.LabId = 2;
                db.PatientLabs.Add(patientLab1);
                db.SaveChanges();

                PatientLab patientLab2 = new PatientLab();
                patientLab1.PatientId = 1;
                patientLab1.LabId = 1;
                db.PatientLabs.Add(patientLab1);
                db.SaveChanges();

                PatientLab patientLab3 = new PatientLab();
                patientLab1.PatientId = 2;
                patientLab1.LabId = 1;
                db.PatientLabs.Add(patientLab1);
                db.SaveChanges();

                PatientLab patientLab4 = new PatientLab();
                patientLab1.PatientId = 2;
                patientLab1.LabId = 3;
                db.PatientLabs.Add(patientLab1);
                db.SaveChanges();

                PatientLab patientLab5 = new PatientLab();
                patientLab1.PatientId = 2;
                patientLab1.LabId = 2;
                db.PatientLabs.Add(patientLab1);
                db.SaveChanges();
                

            } 

        }
    }
}
