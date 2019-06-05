using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace DrugPrescriptionSystemVersion1.DbModels
{
    public class MedicalSpecialist
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(30)]
        public string  LastName { get; set; }

        public Department Department { get; set; }

        public ICollection<Patient> Patients { get; set; }

        public MedicalSpecialist()
        {
            Patients = new Collection<Patient>();
        }

    }
}
