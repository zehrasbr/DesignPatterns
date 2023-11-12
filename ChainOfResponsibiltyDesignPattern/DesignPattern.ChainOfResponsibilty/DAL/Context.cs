using Microsoft.EntityFrameworkCore;

namespace DesignPattern.ChainOfResponsibilty.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=UNKNOWN\\SQLEXPRESS;initial catalog=DesignPattern1;integrated security=true");
        }
        public DbSet<CustomerProcess> CustomerProcesses {  get; set; }
    }
}
