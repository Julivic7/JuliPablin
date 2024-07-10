using System.Data;
using Venar.Data;
using Venar.Entities;


namespace Venar.SVC
{
    public class DiagnosticSVC
    {
        DataServices dataService = new DataServices();
        DiagnosticResult diagnostic;
        public DiagnosticSVC()
        {


        }
        public List<DiagnosticResult> GetDiagnostic(List<int> symptomIds)
        {
            List<DiagnosticResult> diagnostic = new List<DiagnosticResult>();

            Dictionary<string, string> parameters = new Dictionary<string, string>();

            for (int i = 0; i < symptomIds.Count; i++)
            {
                parameters.Add($"@symptomId{i}", symptomIds[i].ToString());
            }

            parameters.Add("@InputSymptomCount", symptomIds.Count.ToString());

            DataTable result = dataService.Selection(@"
     SELECT i.Name, 
            COUNT(DISTINCT ils.SymptomId) AS MatchCount,
            FORMAT((CAST(COUNT(DISTINCT ils.SymptomId) AS FLOAT) / @InputSymptomCount) * 100, 'F2') AS MatchPercentage
     FROM Illnesses i
     JOIN IllnessSymptoms ils ON i.Id = ils.IllnessId
     WHERE ils.SymptomId IN (" + string.Join(",", symptomIds.Select((id, index) => $"@symptomId{index}")) + @")
     GROUP BY i.Name
     HAVING COUNT(DISTINCT ils.SymptomId) > 0
     ORDER BY MatchPercentage DESC", parameters);

            if (result != null)
            {
                foreach (DataRow row in result.Rows)
                {
                    string results = row["Name"].ToString();
                    int matchCount = Convert.ToInt32(row["MatchCount"]);
                    string matchPercentage = row["MatchPercentage"].ToString();

                    diagnostic.Add(new DiagnosticResult
                    {
                        Results = results,
                        MatchCount = matchCount,
                        MatchPercentage = matchPercentage
                    });
                }
            }

            return diagnostic;
        }
        }
    }



