using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Premium.Calculator.Domain;

namespace Premium.Calculator.Persistence.Contexts.PremiumCalculator
{
    /// <summary>
    /// THis is class is used for migration tools to work at design time
    /// </summary>
    public class PremiumCalculatorDbContext : DbContext
    {
        public PremiumCalculatorDbContext(DbContextOptions<PremiumCalculatorDbContext> options) 
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            foreach (var relationship in builder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=PremiumCalculator.db");
        }
        public DbSet<Customer> Customers { get; set; }
    }
}
