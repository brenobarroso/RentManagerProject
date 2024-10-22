using Microsoft.EntityFrameworkCore;

namespace Database;

public class RentDbContext : DbContext
{
    public RentDbContext(DbContextOptions<RentDbContext> options) :base(options)
    {
        
    }
}