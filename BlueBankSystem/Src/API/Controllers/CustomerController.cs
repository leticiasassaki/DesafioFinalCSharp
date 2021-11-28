using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueBank.System.Services.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
       
               

        [HttpGet]
        public Dictionary<Guid, string> Get()
        {
            return CustomerRepository.Customers;
        }

        [HttpGet]
        [Route("{id}")]
        public string GetById([FromRoute] Guid id)
        {
            return CustomerRepository.Customers[id];
        }

        [HttpPost]
        public void Add([FromBody] AddCustomerRequest request)
        {
            CustomerRepository.Customers.Add(Guid.NewGuid(), request.Nome);
        }

    }
}

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlueBank.System.Services.API.Controllers
{
    public class AddCustomerRequest
    {
        public string Nome { get; set; }
    }
}
