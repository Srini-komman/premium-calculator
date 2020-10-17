using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Premium.Calculator.Persistence.Contexts.PremiumCalculator
{
    class PremiumCalculatorContextFactory : IDesignTimeDbContextFactory<PremiumCalculatorDbContext>
    {
        public PremiumCalculatorDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<PremiumCalculatorDbContext>();
            optionsBuilder.UseSqlite("Data Source=PremiumCalculator.db");

            return new PremiumCalculatorDbContext(optionsBuilder.Options);
        }
    }
}
