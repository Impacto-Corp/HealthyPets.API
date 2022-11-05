using HealthyPets.API.Appointments.Domain.Model;
using HealthyPets.API.MedicalRecords.Domain;
using Microsoft.EntityFrameworkCore;

namespace HealthyPets.API.Shared.Persistence.Contexts;

public class AppDbContext:DbContext
{
    public DbSet<Evaluation> Evaluations { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
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
        
            //Relationships
        //builder.Entity<Appointment>().HasMany(p=>p.Evaluation).WithOne(p=>p.Appo)
        //builder.Entity<Appointment>().HasMany(p=>p.Pet).WithOne(p=>p.Appo)







    }
}