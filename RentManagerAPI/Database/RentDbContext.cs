using Microsoft.EntityFrameworkCore;
using Models.Persons;
using Models.Properties;

namespace Database;

public class RentDbContext : DbContext
{
    public RentDbContext(DbContextOptions<RentDbContext> options) : base(options)
    {
    }

    public DbSet<Person> Persons { get; set; }
    public DbSet<Property> Properties { get; set; }
}