using System;
using System.Data.Entity;

namespace MedicoreHospital.Models
{
    public class HospitalContext : DbContext
    {
        public HospitalContext() : base("name=HospitalContext")
        {
            // Disables the automated migration checking for instant speed
            Database.SetInitializer<HospitalContext>(null);
        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Admission> Admissions { get; set; }
    }
}
//check
//check2