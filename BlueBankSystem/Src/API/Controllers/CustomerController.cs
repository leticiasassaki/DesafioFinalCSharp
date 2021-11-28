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
        public Guid Add([FromBody] AddCustomerRequest request)
        {
            var id = Guid.NewGuid();
            CustomerRepository.Customers.Add(Guid.NewGuid(), request.Nome);
            return id;
        }

        [HttpDelete]
        [Route("{id}")]
        public void Remove([FromRoute]Guid id)
        {
            CustomerRepository.Customers.Remove(id);
        }

        [HttpPut]
        [Route("{id}")]
        public void Update([FromRoute]Guid id, [FromBody]UpdateCustomerRequest request)
        {
            request.id = id;
            CustomerRepository.Customers[id] = request.Nome;
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
