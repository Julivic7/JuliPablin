using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venar.Entities.Views
{
    public class PatientViewModel
    {
        public int PatientId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Dni { get; set; }
        public string HasMedicalHistory { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Location { get; set; }
        public string MedicalCoverage { get; set; }
    }
}
