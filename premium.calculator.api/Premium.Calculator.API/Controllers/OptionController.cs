using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Premium.Calculator.Domain;
using Premium.Calculator.Persistence.Repositories;

namespace Premium.Calculator.API.Controllers
{

    public class OptionController : ControllerBase
    {
        private readonly UnitOfWork unitOfWork;
        public OptionController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork as UnitOfWork;
        }
        // GET api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customer>>> Get()
        {
            List<Customer> customers = await this.unitOfWork.CustomerRepository.GetCustomerWithOccupationAsync();

            return Ok(customers);
        }
    }
}
