using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Premium.Calculator.Domain;
using System.ComponentModel;

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
            base.OnModelCreating(builder);
            foreach (var relationship in builder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            // Setting up the relationship(Primary key and Foriegn key) between Occupation and Occupation Rating
            builder.Entity<OccupationRating>(c => c.HasKey(c => new { c.Id }));
            builder.Entity<Occupation>(c => c.HasKey(c => new { c.Id }));
            builder.Entity<Occupation>()                
                .HasOne(or => or.OccupationRating)
                .WithMany(o => o.Occupations)
                .HasForeignKey(or => or.OccupationRatingId);

            // Setting up the relationship(Primary key and Foriegn key) between Customer and Occupation
            builder.Entity<Customer>(c => c.HasKey(c => new { c.Id }));
            builder.Entity<Customer>()
                .HasOne(c => c.Occupation)
                .WithMany(o => o.Customers)
                .HasForeignKey(o => o.OccupationId);            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {            
        }

        public DbSet<OccupationRating> OccupationRatings { get; set; }        
        public DbSet<Occupation> Occupations { get; set; }
        public DbSet<Customer> Customers { get; set; }


    }
}
