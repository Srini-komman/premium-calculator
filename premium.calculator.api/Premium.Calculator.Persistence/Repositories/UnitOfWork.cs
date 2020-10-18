using Premium.Calculator.Persistence.Contexts.PremiumCalculator;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Domains = Premium.Calculator.Domain;
using Premium.Calculator.Persistence.Repositories.Customer;

namespace Premium.Calculator.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PremiumCalculatorDbContext premiumCalculatorContext;
        private GenericRepository<Domains.Customer> customerRepository;
        private GenericRepository<Domains.Occupation> occupationRepository;
        private GenericRepository<Domains.OccupationRating> occupationRatingRepository;
        public UnitOfWork(PremiumCalculatorDbContext premiumCalculatorContext)
        {
            this.premiumCalculatorContext = premiumCalculatorContext;            
        }        
        public GenericRepository<Domains.Customer> CustomerRepository
        {
            get
            {
                if (this.customerRepository == null)
                {
                    this.customerRepository = new GenericRepository<Domains.Customer>(this.premiumCalculatorContext);
                }
                return this.customerRepository;
            }
        }

        public GenericRepository<Domains.Occupation> OccupationRepository
        {
            get
            {
                if (this.occupationRepository == null)
                {
                    this.occupationRepository = new GenericRepository<Domains.Occupation>(this.premiumCalculatorContext);
                }
                return this.occupationRepository;
            }
        }

        public GenericRepository<Domains.OccupationRating> OccupationRatingRepository
        {
            get
            {
                if (this.occupationRatingRepository == null)
                {
                    this.occupationRatingRepository = new GenericRepository<Domains.OccupationRating>(this.premiumCalculatorContext);
                }
                return this.occupationRatingRepository;
            }
        }

        public void Save()
        {
            this.premiumCalculatorContext.SaveChanges();
        }
        public async Task<int> SaveChangesAsync()
        {
            return await this.premiumCalculatorContext.SaveChangesAsync();
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    this.premiumCalculatorContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
