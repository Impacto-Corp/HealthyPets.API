﻿using System.Text.Json.Serialization;

namespace HealthyPets.API.Security.Domain.Model;

public class User
{
    public string Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Username { get; set; }
    
    [JsonIgnore]
    public string PasswordHash { get; set; }
}