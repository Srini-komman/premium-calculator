using Premium.Calculator.Persistence.Contexts.PremiumCalculator;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Domains = Premium.Calculator.Domain;
using CustomerRepo = Premium.Calculator.Persistence.Repositories.Customer;
using OccupationRepo = Premium.Calculator.Persistence.Repositories.Occupation;
using OccupationRatingRepo = Premium.Calculator.Persistence.Repositories.OccupationRating;

namespace Premium.Calculator.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PremiumCalculatorDbContext premiumCalculatorContext;
        private CustomerRepo.ICustomerRepository customerRepository;
        private OccupationRepo.IOccupationRepository occupationRepository;
        private OccupationRatingRepo.IOccupationRatingRepository occupationRatingRepository;
        
        public UnitOfWork(PremiumCalculatorDbContext premiumCalculatorContext,
            CustomerRepo.ICustomerRepository customerRepository,
            OccupationRepo.IOccupationRepository occupationRepository,
            OccupationRatingRepo.IOccupationRatingRepository occupationRatingRepository
            )
        {
            this.premiumCalculatorContext = premiumCalculatorContext;
            this.customerRepository = customerRepository;
            this.occupationRepository = occupationRepository;
            this.occupationRatingRepository = occupationRatingRepository;
        }
        public CustomerRepo.ICustomerRepository CustomerRepository
        {
            get
            {                
                return this.customerRepository;
            }
        }

        public OccupationRepo.IOccupationRepository OccupationRepository
        {
            get
            {               
                return this.occupationRepository;
            }
        }

        public OccupationRatingRepo.IOccupationRatingRepository OccupationRatingRepository
        {
            get
            {              
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
