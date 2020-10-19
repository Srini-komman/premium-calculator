using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Premium.Calculator.API.Contracts.Response
{
    public class ErrorCode
    {
        public string FieldName { get; set; }
        public string Message { get; set; }
    }
}
