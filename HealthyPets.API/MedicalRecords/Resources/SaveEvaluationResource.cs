﻿using System.ComponentModel.DataAnnotations;

namespace HealthyPets.API.MedicalRecords.Resources;

public class SaveEvaluationResource
{
    [Required]
    public string Name { get; set; }
}