using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venar.Entities
{
    public class PatientViewModel
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int MedicalCoverageId { get; set; }
        public int LocationId { get; set; }
        public string LocationName { get; set; }
    }
}
