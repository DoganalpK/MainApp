using MainApp.Application.Interfaces.Contexts;
using MainApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace MainApp.Persistence.Contexts
{
    public class MainAppDbContext : DbContext, IMainAppDbContext
    {
        protected MainAppDbContext(DbContextOptions options) : base(options)
        {
        }

        public MainAppDbContext(DbContextOptions<MainAppDbContext> options) : this((DbContextOptions)options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //    optionsBuilder.UseSqlServer("server=localhost; database=MainAppDb; integrated security=true;");
        //}

        //public async Task<int> SaveChangesAsync()
        //{
        //    return await base.SaveChangesAsync();
        //}

        #region [ DB SETS ]

        public DbSet<Product> Products { get; set; }

        #endregion
    }
}
