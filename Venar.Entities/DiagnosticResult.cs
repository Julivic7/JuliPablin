using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venar.Entities
{    public class DiagnosticResult
    {
        public string Results { get; set; }
        public string MatchPercentage { get; set; }
        public int MatchCount { get; set; }
    
        public override string ToString()
        {
            return $"{Results} - {MatchPercentage:F2}% de coincidencia ({MatchCount} de  síntomas)";//{SymptomsIds.Count}
        }
    }
}
