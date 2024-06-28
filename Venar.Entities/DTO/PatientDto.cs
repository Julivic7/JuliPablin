using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venar.DTO
{

    public class PatientDto
    {
        public Guid Id { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public string dni { get; set; }
        public string MedicalCoverage { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string gender { get; set; }
        public string location { get; set; }

        public PatientDto()
        {
        }
    }
}