using BlueBank.System.Application.Requests;
using BlueBank.System.Application.Queries;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlueBank.System.Application.Commands;
using BlueBank.System.Data.Repositories;
using BlueBank.System.Data.Contexts;

namespace BlueBank.System.Services.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerRepository _repository;
        public CustomerController(SystemContext context)
        {
            _repository = new CustomerRepository(context);
        }

              
        [HttpGet]
        public IActionResult Get()
        {
            
            var handler = new GetAllCustomerQuery(_repository);

            var response = handler.Handle(new GetAllCustomerRequest());

            return Ok(response);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById([FromRoute] Guid id)
        {
            var request = new GetCustomerByIdRequest() { Id = id };

            var handler = new GetCustomerByIdQuery(_repository);
            var response = handler.Handle(request);

            return Ok(response);
        }
        

        [HttpPost]
        public IActionResult Add([FromBody] AddCustomerRequest request)
        {
            
            var command  = new AddCustomerCommand(_repository);
            var response = command.Handle(request);
            return Created("", response);
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Remove([FromRoute]Guid id)
        {
            var request = new RemoveCustomerByIdRequest() { Id = id};
            var handler = new RemoveCustomerByIdCommand();
            var response = handler.Handle(request);
            
            return Ok(response);
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Update([FromRoute]Guid id, [FromBody]UpdateCustomerRequest request)
        {
            request.Id = id;
            var handler = new UpdateCustomerCommand(_repository);

            var response = handler.Handle(request);

            return Ok(response);
        }
    }


    


}
