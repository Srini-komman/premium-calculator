using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Premium.Calculator.Application.Customers;
using Premium.Calculator.Domain;
using Premium.Calculator.Persistence.Repositories;


namespace Premium.Calculator.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        
        private readonly IMediator mediator;
        public CustomerController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        // GET api/values
        [HttpGet]
        public async Task<ActionResult<List<Customer>>> List()
        {
            List<Customer> customers = await this.mediator.Send(new List.Query());

            return Ok(customers);
        }        
    }
}
