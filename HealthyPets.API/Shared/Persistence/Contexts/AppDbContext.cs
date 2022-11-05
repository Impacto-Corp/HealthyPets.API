using HealthyPets.API.MedicalRecords.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace HealthyPets.API.Shared.Persistence.Contexts;

public class AppDbContext:DbContext
{
    public DbSet<Evaluation> Evaluations { get; set; }
    public AppDbContext(DbContextOptions options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        
        //Evaluation Configuration 
        builder.Entity<Evaluation>().ToTable("Evaluations");
        builder.Entity<Evaluation>().HasKey(p => p.Id);
        builder.Entity<Evaluation>().Property(p => p.Id)
            .IsRequired().ValueGeneratedOnAdd();
        builder.Entity<Evaluation>().Property(p => p.Name)
            .IsRequired().HasMaxLength(40);

        //Fluent API
    }
}