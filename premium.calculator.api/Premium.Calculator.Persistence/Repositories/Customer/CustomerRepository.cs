using Microsoft.EntityFrameworkCore;
using Premium.Calculator.Persistence.Contexts.PremiumCalculator;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Domains = Premium.Calculator.Domain;

namespace Premium.Calculator.Persistence.Repositories.Customer
{
    public class CustomerRepository : GenericRepository<Domains.Customer>, ICustomerRepository
    {

        public CustomerRepository(PremiumCalculatorDbContext context)
            : base(context)
        {

        }        

        public PremiumCalculatorDbContext DataContext
        {
            get { return Context as PremiumCalculatorDbContext; }
        }

        public async Task<List<Domains.Customer>> GetCustomerWithOccupationAsync()
        {
            var customer = await this.DataContext.Customers.Include(o => o.Occupation).ToListAsync();
            return customer;
        }
    }
}
