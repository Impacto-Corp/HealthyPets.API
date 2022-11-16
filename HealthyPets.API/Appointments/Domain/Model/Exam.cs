﻿using HealthyPets.API.Patients.Domain.Model;
using HealthyPets.API.Profiles.Domain.Model;

namespace HealthyPets.API.Appointments.Domain.Model;

public class Exam
{
    public int Id  { get; set; }
    public DateTime Date { get; set; }
    public Client Client { get; set; }
    public Pet Pet { get; set; }
    public double Cost { get; set; }
}