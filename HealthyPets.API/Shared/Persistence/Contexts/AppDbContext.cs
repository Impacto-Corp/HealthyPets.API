using HealthyPets.API.Appointments.Domain.Model;
using HealthyPets.API.MedicalRecords.Domain;
using HealthyPets.API.MedicalRecords.Domain.Models;
using HealthyPets.API.Patients.Domain.Model;
using HealthyPets.API.Profiles.Domain.Model;
using HealthyPets.API.Shared.Extensions;
using HealthyPets.API.Social.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace HealthyPets.API.Shared.Persistence.Contexts;

public class AppDbContext:DbContext
{
    public DbSet<Evaluation> Evaluations { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Pet> Pets { get; set; }
    public DbSet<Vet> Vets { get; set; }
    public DbSet<Message> Messages { get; set; }
    public AppDbContext(DbContextOptions options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        
        
        // -------------------------- Evaluation Entity ----------------------------
        
        //Evaluation Configuration 
        builder.Entity<Evaluation>().ToTable("Evaluations");
        builder.Entity<Evaluation>().HasKey(p => p.Id);
        builder.Entity<Evaluation>().Property(p => p.Id)
            .IsRequired().ValueGeneratedOnAdd();
        builder.Entity<Evaluation>().Property(p => p.Name)
            .IsRequired().HasMaxLength(40);

        //Fluent API
        
        
        
        
        // -------------------------- Appointment Entity ----------------------------
        builder.Entity<Appointment>().ToTable("Appointments");
        builder.Entity<Appointment>().HasKey(p => p.Id);
        builder.Entity<Appointment>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<Appointment>().Property(p => p.Date).IsRequired();
        
        //--------------------------- Pet Entity ------------------------------------
        builder.Entity<Pet>().ToTable("Pets");
        builder.Entity<Pet>().HasKey(p => p.Id);
        builder.Entity<Pet>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<Pet>().Property(p => p.Name).IsRequired().HasMaxLength(20);
        builder.Entity<Pet>().Property(p => p.Species).IsRequired().HasMaxLength(30);
        builder.Entity<Pet>().HasMany(p => p.Record).WithOne(p => p.Pet);
        builder.Entity<Pet>().HasOne(p => p.Owner).WithOne(p => p.Pet);
        builder.Entity<Pet>().HasOne(p => p.Appointment).WithOne(p => p.Pet);
        
        //--------------------------- Message Entity --------------------------------
        builder.Entity<Message>().ToTable("Messages");
        builder.Entity<Message>().HasKey(p => p.Id);
        builder.Entity<Message>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<Message>().Property(p => p.Content).IsRequired().HasMaxLength(350);
        builder.Entity<Message>().HasOne(p => p.User).WithOne(p => p.Comment);
        
        // -------------------------- Client Entity ----------------------------
        builder.Entity<Client>().ToTable("Clients");
        builder.Entity<Client>().HasKey(p => p.Id);
        builder.Entity<Client>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<Client>().Property(p => p.Name)
            .IsRequired().HasMaxLength(40);
        // -------------------------- Doctor Entity ----------------------------
        builder.Entity<Doctor>().ToTable("Doctors");
        builder.Entity<Doctor>().HasKey(p => p.Id);
        builder.Entity<Doctor>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<Doctor>().Property(p => p.Name)
            .IsRequired().HasMaxLength(40);
        // -------------------------- Veterinary Entity ----------------------------
        builder.Entity<Vet>().ToTable("Veterinaries");
        builder.Entity<Vet>().HasKey(p => p.Id);
        builder.Entity<Vet>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<Vet>().Property(p => p.Name)
            .IsRequired().HasMaxLength(40);




        builder.UseSnakeCaseNamingConvention();
    }
}