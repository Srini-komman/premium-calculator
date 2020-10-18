using System;
using System.Collections.Generic;
using System.Text;
using Domains = Premium.Calculator.Domain;
using Premium.Calculator.Persistence.Contexts.PremiumCalculator;

namespace Premium.Calculator.Persistence.Repositories.Occupation
{
    public class OccupationRepository : GenericRepository<Domains.Occupation>, IOccupationRepository
    {
        public OccupationRepository(PremiumCalculatorDbContext context)
            : base(context)
        {

        }

        public PremiumCalculatorDbContext DataContext
        {
            get { return Context as PremiumCalculatorDbContext; }
        }
    }
}
