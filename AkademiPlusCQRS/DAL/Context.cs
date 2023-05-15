using Microsoft.EntityFrameworkCore;

namespace AkademiPlusCQRS.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DERYA;initial catalog= AkademmiPlusCQRSDb; integrated security=true");
        }
        public DbSet<Product> Products { get; set; }
    }
}
