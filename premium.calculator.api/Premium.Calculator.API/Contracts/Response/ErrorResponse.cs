using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Premium.Calculator.API.Contracts.Response
{
    public class ErrorResponse
    {
        public List<ErrorCode> Errors { get; set; }
    }
}
