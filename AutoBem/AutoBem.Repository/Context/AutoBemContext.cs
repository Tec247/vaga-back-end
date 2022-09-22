using AutoBem.Repository.Context.Mappings;
using Microsoft.EntityFrameworkCore;

namespace AutoBem.Repository.Context
{
    public class AutoBemContext : DbContext
    {
        public AutoBemContext() { }

        public AutoBemContext(DbContextOptions options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProprietarioMapping());
            modelBuilder.ApplyConfiguration(new VeiculoMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
