using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using Premium.Calculator.API.Contracts.Requests;
using Premium.Calculator.API.Shared;

namespace Premium.Calculator.API.Validators
{
    /// <summary>
    /// This class is used to apply validations on Premium calculator request
    /// </summary>
    public class PremiumCalcRequestValidator : AbstractValidator<CalculatePremiumRequest>
    {        
        public PremiumCalcRequestValidator()
        {            
            RuleFor(cp => cp.Name).NotEmpty().WithMessage(Constants.CUSTOMER_NAME_EMPTY_ERROR)
                                    .Length(2, 50).WithMessage(Constants.CUSTOMER_NAME_INVALID_LENGTH_ERROR);
            RuleFor(cp => cp.Age).NotEmpty().WithMessage(Constants.CUSTOMER_AGE_INVALID_ERROR);                                     ;
            RuleFor(cp => cp.DateOfBirth).NotNull().WithMessage(Constants.CUSTOMER_DOB_EMPTY_ERROR);
            RuleFor(cp => cp.OccupationName).NotNull().WithMessage(Constants.CUSTOMER_OCCUPATIONNAME_EMPTY_ERROR)
                .Length(2, 50).WithMessage(Constants.CUSTOMER_OCCUPATIONNAME_INVALID_ERROR);
            RuleFor(cp => cp.DeathSumInsured).NotNull().WithMessage(Constants.CUSTOMER_DEATH_SUM_INSURED_ERROR);
        }
    }
}
