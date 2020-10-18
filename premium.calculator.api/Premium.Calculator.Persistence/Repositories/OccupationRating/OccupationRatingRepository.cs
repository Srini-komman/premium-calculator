using System;
using System.Collections.Generic;
using System.Text;
using Domains = Premium.Calculator.Domain;
using Premium.Calculator.Persistence.Contexts.PremiumCalculator;

namespace Premium.Calculator.Persistence.Repositories.OccupationRating
{
    public class OccupationRatingRepository : GenericRepository<Domains.OccupationRating>, IOccupationRatingRepository
    {
        public OccupationRatingRepository(PremiumCalculatorDbContext context)
            : base(context)
        {

        }

        public PremiumCalculatorDbContext DataContext
        {
            get { return Context as PremiumCalculatorDbContext; }
        }
    }
}
