using InstrumentryBackEnd.Models;
using Microsoft.EntityFrameworkCore;

namespace InstrumentryBackend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Instrument> Instruments { get; set; }


    }
}