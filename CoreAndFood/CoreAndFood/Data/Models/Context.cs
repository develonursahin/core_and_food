using Microsoft.EntityFrameworkCore;
using System;

namespace CoreAndFood.Data.Models
{
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DERINDOST\\SQLEXPRESS; database=DbCoreFood; integrated security=true");
        }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Admin> Admins { get; set; }

        internal new void SavedChanges()
        {
            throw new NotImplementedException();
        }
    }
}
