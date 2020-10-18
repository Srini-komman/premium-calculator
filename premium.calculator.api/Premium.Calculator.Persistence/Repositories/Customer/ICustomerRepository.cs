using Premium.Calculator.Persistence.Contexts.PremiumCalculator;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using System.Threading.Tasks;
using Domains = Premium.Calculator.Domain;

namespace Premium.Calculator.Persistence.Repositories.Customer
{
    public interface ICustomerRepository : IGenericRepository<Domains.Customer>
    {
        public PremiumCalculatorDbContext DataContext { get; }

        public Task<List<Domains.Customer>> GetCustomerWithOccupationAsync();
    }
}
