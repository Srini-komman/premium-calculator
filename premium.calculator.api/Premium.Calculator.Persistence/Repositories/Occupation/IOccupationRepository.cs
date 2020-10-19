using System;
using System.Collections.Generic;
using System.Text;
using Domains = Premium.Calculator.Domain;
using Premium.Calculator.Persistence.Contexts.PremiumCalculator;
using System.Threading.Tasks;

namespace Premium.Calculator.Persistence.Repositories.Occupation
{
    public interface IOccupationRepository : IGenericRepository<Domains.Occupation>
    {
        public Task<List<Domains.Occupation>> GetOccupationWithRatingAsync();
        public PremiumCalculatorDbContext DataContext { get; }
    }
}
