using DrugPrescriptionSystemVersion1.DbModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrugPrescriptionSystemVersion1.DbContextClass
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options) { }

        public DbSet<Patient> Patients { get; set; }

        public DbSet<MedicalSpecialist> MedicalSpecialists { get; set; }

        public DbSet<Department> Departments { get; set; }
    }
}
