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
        public IActionResult Get()
        {
            return Ok(CustomerRepository.Customers);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById([FromRoute] Guid id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Add([FromBody] AddCustomerRequest request)
        {
            return Created("", null);
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Remove([FromRoute]Guid id)
        {
           return Ok();
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Update([FromRoute]Guid id, [FromBody]UpdateCustomerRequest request)
        {
            return Ok();
        }
    }


    public class AddCustomerRequest
    {
        public string Nome { get; set; }
    }

    public class UpdateCustomerRequest
    {
        public Guid id { get; set; }
        public string Nome { get; set; }
    }

}
