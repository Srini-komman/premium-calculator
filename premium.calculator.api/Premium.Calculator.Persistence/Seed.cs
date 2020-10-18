using Microsoft.EntityFrameworkCore.Internal;
using Premium.Calculator.Domain;
using Premium.Calculator.Persistence.Contexts.PremiumCalculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace Premium.Calculator.Persistence
{
    class Seed
    {
        private static IList<Occupation> GetOccupationsSeedData()
        {
            var occupationsSeedData = new List<Occupation>
            {
                new Occupation
                {
                    Id = 1,
                    Name = "Cleaner",                    
                    OccupationRatingId = 3
                },
                new Occupation
                {
                    Id = 2,
                    Name = "Doctor",
                    OccupationRatingId = 1
                },
                new Occupation
                {
                    Id = 3,
                    Name = "Author",
                    OccupationRatingId = 2
                },
                new Occupation
                {
                    Id = 4,
                    Name = "Farmer",
                    OccupationRatingId = 4
                },
                new Occupation
                {
                    Id = 5,
                    Name = "Mechanic",
                    OccupationRatingId = 4
                },
                new Occupation
                {
                    Id = 6,
                    Name = "Florist",
                    OccupationRatingId = 3
                }
            };

            return occupationsSeedData;
        }

        private static IList<OccupationRating> GetOccupationRatingsSeedData()
        {
            var occupationRatingsSeedData = new List<OccupationRating>
            {
                new OccupationRating
                {
                    Id = 1,
                    Name = "Professional"
                },
                new OccupationRating
                {
                    Id = 2,
                    Name = "White Collar"
                },
                new OccupationRating
                {
                    Id = 3,
                    Name = "Light Manual"
                },
                new OccupationRating
                {
                    Id = 4,
                    Name = "Heavy Manual"
                }
            };

            return occupationRatingsSeedData;
        }

        private static IList<Customer> GetCustomersSeedData()
        {
            var customersSeedData = new List<Customer>
                {
                    new Customer
                    {
                        Name = "Elizabeth Johnson",
                        Age = 35,
                        DateOfBirth = DateTime.Now.AddYears(-35),
                        OccupationId = 1,
                        DeathSumInsured = 100000m
                    },
                    new Customer
                    {
                        Name = "Scott Thomson",
                        Age = 42,
                        DateOfBirth = DateTime.Now.AddYears(-42),
                        OccupationId = 4,
                        DeathSumInsured = 90000m
                    }
                };

            return customersSeedData;
        }

        public static void SeedData(PremiumCalculatorDbContext context)
        {
            if (!context.OccupationRatings.Any())
            {
                var occupations = GetOccupationRatingsSeedData();
            }
            if (!context.Occupations.Any())
            {
                var occupationRatings = GetOccupationsSeedData();
            }
            if (!context.Customers.Any())
            {
                var customers = GetCustomersSeedData();
            }
        }
    }
}
