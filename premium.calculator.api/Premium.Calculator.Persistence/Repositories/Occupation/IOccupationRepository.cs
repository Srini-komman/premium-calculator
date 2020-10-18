using System;
using System.Collections.Generic;
using System.Text;
using Domains = Premium.Calculator.Domain;
using Premium.Calculator.Persistence.Contexts.PremiumCalculator;

namespace Premium.Calculator.Persistence.Repositories.Occupation
{
    public interface IOccupationRepository : IGenericRepository<Domains.Occupation>
    {
        public PremiumCalculatorDbContext DataContext { get; }
    }
}
