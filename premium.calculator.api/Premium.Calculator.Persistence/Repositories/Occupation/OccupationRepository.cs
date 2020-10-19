using System;
using System.Collections.Generic;
using System.Text;
using Domains = Premium.Calculator.Domain;
using Premium.Calculator.Persistence.Contexts.PremiumCalculator;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

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

        public async Task<List<Domains.Occupation>> GetOccupationWithRatingAsync()
        {
            var occupations = await this.DataContext.Occupations.Include(o => o.OccupationRating).ToListAsync();
            return occupations;            
        }
    }
}
