using DrugPrescriptionSystemVersion1.DbContextClass;
using DrugPrescriptionSystemVersion1.DbModels;
using DrugPrescriptionSystemVersion1.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrugPrescriptionSystemVersion1.Repository
{
    public class PatientRepository : IPatientRepository
    {
        private readonly ApplicationDbContext _db;

        public PatientRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public ICollection<Patient> SelectAll()
        {
            var patientQuery = _db.Patients.Include(m => m.MedicalSpecialist);
            return patientQuery.ToList();
        }

        public async Task<Patient> SelectByIdAsync(long Id)
        {
            var patient = await _db.Patients.Include(m => m.MedicalSpecialist)
                .SingleOrDefaultAsync(p => p.Id == Id);
            return patient;
        }
    }
}
