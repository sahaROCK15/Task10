using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;

namespace Task10.Models
{
    public class TravelContext : DbContext
    {
        public DbSet<Travel> Travels { get; set; }
        public TravelContext(DbContextOptions<TravelContext> options)
            : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }
    }
}
