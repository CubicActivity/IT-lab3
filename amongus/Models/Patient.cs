using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace amongus.Models
{
	public class Patient
	{

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public Gender Gender { get; set; }

        [Display(Name = "Код на пациентот")]
        [Range(10000,99999)]
        public int PatientCode { get; set; }
        public virtual List<Doctor> Doctors { get; set; }

    }
}