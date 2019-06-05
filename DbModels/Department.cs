using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace DrugPrescriptionSystemVersion1.DbModels
{
    public class Department
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<MedicalSpecialist> MedicalSpecialists { get; set; }

        public Department()
        {
            MedicalSpecialists = new Collection<MedicalSpecialist>();
        }


    }
}
