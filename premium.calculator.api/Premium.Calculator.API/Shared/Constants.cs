using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Premium.Calculator.API.Shared
{
    public class Constants
    {
        public const string STATUS_SUCCESS = "SUCCESS";
        public const string STATUS_FAILED = "FAILED";
        public const string VALIDATION_FAILED = "Validation Failed";

        public const string CUSTOMER_NAME_EMPTY_ERROR = "Customer name is empty";
        public const string CUSTOMER_NAME_INVALID_LENGTH_ERROR = "Customer name is Invalide";
        public const string CUSTOMER_DOB_EMPTY_ERROR = "Cusotmer Date of Birth is Invalid";
        public const string CUSTOMER_OCCUPATIONNAME_EMPTY_ERROR = "Customer Occupation is empty";
        public const string CUSTOMER_OCCUPATIONNAME_INVALID_ERROR = "Customer Occupation is invalid";
        public const string CUSTOMER_DEATH_SUM_INSURED_ERROR = "Death sum insured is Invalid";
        public const string CUSTOMER_AGE_INVALID_ERROR = "Cusotmer Age is Invalid";

    }
}
