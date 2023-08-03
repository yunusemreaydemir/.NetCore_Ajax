using Microsoft.EntityFrameworkCore;

namespace Ajax.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-FIKBBE9;initial catalog = AjaxDb; integrated Security=true");
        }
        public DbSet<Customer> Customers { get; set; }
    }
}
