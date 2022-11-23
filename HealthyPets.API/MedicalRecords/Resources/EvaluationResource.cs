namespace HealthyPets.API.MedicalRecords.Resources;

public class EvaluationResource
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime Date { get; set; }
    public string Report { get; set; }
}