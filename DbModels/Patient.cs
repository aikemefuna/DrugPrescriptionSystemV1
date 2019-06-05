using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DrugPrescriptionSystemVersion1.DbModels
{
    public class Patient
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Input cannot be more than 30")]
        public string FirstName { get; set; }


        [Required]
        [StringLength(30, ErrorMessage = "Input cannot be more than 30")]
        public string LastName { get; set; }

        [Required]
        public string Ailment { get; set; }

        [Required]
        public string Medication { get; set; }

        [Required]
        public string Dosage { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateUpdated { get; set; }

        public MedicalSpecialist MedicalSpecialist { get; set; }



    }
}
