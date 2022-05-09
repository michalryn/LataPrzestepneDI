using LataPrzestepneDI.Models;
using Microsoft.EntityFrameworkCore;

namespace LataPrzestepneDI.Data
{
    public class PeopleContext : DbContext
    {
        public PeopleContext(DbContextOptions options) : base(options) { }
        public DbSet<Person> Person { get; set; }
    }
}
