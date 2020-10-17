using System;
using System.Collections.Generic;
using System.Text;

namespace Premium.Calculator.Domain
{
    public class OccupationRating
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Factor { get; set; }
        public virtual ICollection<Occupation> Occupations { get; set; }
    }
}
