using URLShortener.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace URLShortener.Data
{
    public class DataContext : DbContext
    {
        public DbSet<LinkEntity> Links { get; set; }


        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
