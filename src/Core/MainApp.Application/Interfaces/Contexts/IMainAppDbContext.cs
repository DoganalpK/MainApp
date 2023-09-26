using MainApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MainApp.Application.Interfaces.Contexts
{
    public interface IMainAppDbContext
    { 
        DbSet<Product> Products { get; set; }

        Task<int> SaveChangesAsync();//
    }
}
