using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Premium.Calculator.Domain;

namespace Premium.Calculator.Persistence.Contexts
{
    class PremiumCalculatorContext : DbContext
    {
        public PremiumCalculatorContext(DbContextOptions<PremiumCalculatorContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            foreach (var relationship in builder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
        public DbSet<Customer> Customers { get; set; }
    }
}
