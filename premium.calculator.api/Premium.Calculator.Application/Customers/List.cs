using MediatR;
using Premium.Calculator.Domain;
using Premium.Calculator.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Premium.Calculator.Application.Customers
{
    public class List
    {
        public class Query: IRequest<List<Customer>> { }

        public class Handler : IRequestHandler<Query, List<Customer>>
        {
            private readonly UnitOfWork unitOfWork;
            public Handler(IUnitOfWork unitOfWork)
            {
                this.unitOfWork = unitOfWork as UnitOfWork;
            }
            public async Task<List<Customer>> Handle(Query request, CancellationToken cancellationToken)
            {
                List<Customer> customers = await this.unitOfWork.CustomerRepository.GetCustomerWithOccupationAsync();
                return customers;
            }
        }
    }
}
