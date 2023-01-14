using Datatableajaxef.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Datatableajaxef.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<AlumnosEnty> Alumnos { get; set; }
    }
}
