using Microsoft.EntityFrameworkCore;
using Models.Persons;
using Models.Properties;

public class RentManagerDbContext : DbContext
{
    public DbSet<Person> People { get; set; }
    public DbSet<Property> Properties { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configuração do relacionamento Lessor (Locador) com Property
        modelBuilder.Entity<Person>()
            .HasMany(p => p.OwnedProperties)
            .WithOne(p => p.Lessor)
            .HasForeignKey(p => p.LessorId)
            .OnDelete(DeleteBehavior.Restrict);

        // Configuração do relacionamento entre Lessee (Locatário) e Property
        modelBuilder.Entity<Property>()
            .HasOne(p => p.CurrentLessee)
            .WithOne()
            .HasForeignKey<Property>(p => p.CurrentLesseeId)
            .OnDelete(DeleteBehavior.SetNull); // Define que o locatário pode ser removido sem apagar o imóvel
    }
}
