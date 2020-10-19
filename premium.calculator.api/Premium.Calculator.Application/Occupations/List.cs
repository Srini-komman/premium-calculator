using MediatR;
using Premium.Calculator.Domain;
using Premium.Calculator.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Premium.Calculator.Application.Occupations
{
    public class List
    {
        public class Query: IRequest<List<Occupation>> { }

        public class Handler : IRequestHandler<Query, List<Occupation>>
        {
            private readonly UnitOfWork unitOfWork;
            public Handler(IUnitOfWork unitOfWork)
            {
                this.unitOfWork = unitOfWork as UnitOfWork;
            }
            public async Task<List<Occupation>> Handle(Query request, CancellationToken cancellationToken)
            {
                List<Occupation> occupation = await this.unitOfWork.OccupationRepository.GetOccupationWithRatingAsync();
                return occupation;
            }
        }
    }
}
