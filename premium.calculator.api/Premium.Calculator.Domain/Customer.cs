using System;
using System.Collections.Generic;
using System.Text;

namespace Premium.Calculator.Domain
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Occupation { get; set; }
        public decimal DeathSumInsured { get; set; }

    }
}
