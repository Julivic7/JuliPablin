using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venar.Entities;

namespace Venar.DTO
{
    public class MedicDto
    {
        public int MedicId { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Dni { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public int SpecialtyId { get; set; }
        public string SpecialtyName { get; set; }
        public string MedicalRegistration { get; set; }
    }

}
