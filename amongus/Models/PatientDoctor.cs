using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace amongus.Models
{
	public class PatientDoctor
	{
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public List<Patient> Patients { get; set; }

    }
}