using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Premium.Calculator.Domain;
using Premium.Calculator.Persistence.Repositories;

namespace DatingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PremiumCalculatorController : ControllerBase
    {
        private readonly UnitOfWork unitOfWork;
        public PremiumCalculatorController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork as UnitOfWork;
        }
        
        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
    }
}
