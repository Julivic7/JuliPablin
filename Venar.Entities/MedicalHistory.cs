using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venar.Entities
{
    public class MedicalHistory
    {
        public Guid idMedico { get; set; }
        public Guid IdPaciente { get; set; }
        public string Date { get; set; }
        public string Reason { get; set; }

    }
}
