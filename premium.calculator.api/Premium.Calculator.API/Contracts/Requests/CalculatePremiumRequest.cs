using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Premium.Calculator.API.Contracts.Requests
{
    public class CalculatePremiumRequest
    {        
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string OccupationName { get; set; }        
        public decimal DeathSumInsured { get; set; }
    }
}
