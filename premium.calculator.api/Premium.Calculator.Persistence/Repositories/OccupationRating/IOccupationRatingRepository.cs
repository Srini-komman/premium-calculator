using System;
using System.Collections.Generic;
using System.Text;
using Domains = Premium.Calculator.Domain;
using Premium.Calculator.Persistence.Contexts.PremiumCalculator;

namespace Premium.Calculator.Persistence.Repositories.OccupationRating
{
    public interface IOccupationRatingRepository : IGenericRepository<Domains.OccupationRating>
    {
        public PremiumCalculatorDbContext DataContext { get; }
        
    }
}
