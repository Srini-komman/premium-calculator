using System;
using System.Collections.Generic;
using System.Text;

namespace Premium.Calculator.Domain
{
    public class Occupation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int OccupationRatingId { get; set; }
        public OccupationRating OccupationRating { get; set; }        
        public virtual ICollection<Customer> Customers { get; set; }
    }
}
