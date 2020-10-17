using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace Premium.Calculator.Domain
{
    public class Customer
    {
        public Guid Id { get; set; }        
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Guid OccupationId { get; set; }
        public Occupation Occupation { get; set; }
        public decimal DeathSumInsured { get; set; }

    }
}
