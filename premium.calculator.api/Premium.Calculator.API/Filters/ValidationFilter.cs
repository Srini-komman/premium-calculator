using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Premium.Calculator.API.Contracts.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Premium.Calculator.API.Filters
{
    public class ValidationFilter : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if(!context.ModelState.IsValid)
            {
                var modelStateErrors = context.ModelState
                    .Where(e => e.Value.Errors.Count > 0)
                    .ToDictionary(kp => kp.Key, kp => kp.Value.Errors.Select(e => e.ErrorMessage)).ToArray();

                var errorResponse = new ErrorResponse();

                foreach(var error in modelStateErrors)
                {
                    foreach(var innerError in error.Value)
                    {
                        var errorCode = new ErrorCode
                        {
                            FieldName = error.Key,
                            Message = innerError
                        };

                        errorResponse.Errors.Add(errorCode);
                    }

                    context.Result = new BadRequestObjectResult(errorResponse);
                    return;
                }
            }
            await next();
        }
    }
}
