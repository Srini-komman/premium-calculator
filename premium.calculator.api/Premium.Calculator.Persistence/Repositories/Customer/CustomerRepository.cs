using Premium.Calculator.Persistence.Contexts.PremiumCalculator;
using System;
using System.Collections.Generic;
using System.Text;
using Domains = Premium.Calculator.Domain;

namespace Premium.Calculator.Persistence.Repositories.Customer
{
    public class CustomerRepository : GenericRepository<Domains.Customer>, ICustomerRepository
    {

        public CustomerRepository(PremiumCalculatorDbContext context)
            : base(context)
        {

        }        

        public PremiumCalculatorDbContext PremiumCalculatorDbContext
        {
            get { return Context as PremiumCalculatorDbContext; }
        }
    }
}
