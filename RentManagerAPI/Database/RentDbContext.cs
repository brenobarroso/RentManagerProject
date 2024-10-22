using Microsoft.EntityFrameworkCore;
using SeuNamespace.Models;

namespace Database;

public class RentDbContext : DbContext
{
    public RentDbContext(DbContextOptions<RentDbContext> options) : base(options)
    {
    }

    public DbSet<Person> Persons { get; set; }
}