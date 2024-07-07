using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venar.DTO;

namespace Venar.DTO
{
    public class ResultDto
    {
        public bool IsSuccess => Errors.Count == 0;
        public List<string> Errors { get; set; } = new List<string>();
        public string Message { get; set; }
        public MedicDto MedicDto { get; set; }
    }

}
