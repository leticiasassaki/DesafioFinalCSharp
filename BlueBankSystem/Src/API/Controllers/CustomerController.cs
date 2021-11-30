using BlueBank.System.Application.Requests;
using BlueBank.System.Application.Queries;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlueBank.System.Application.Commands;

namespace BlueBank.System.Services.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {    
              
        [HttpGet]
        public IActionResult Get()
        {
            var request = new GetAllCustomerRequest();
            var handler = new GetAllCustomerQueryHandler();

            var response = handler.Handle(request);

            return Ok(response);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById([FromRoute] Guid id)
        {
            var request = new GetCustomerByIdRequest() { Id = id };

            var handler = new GetCustomerByIdQueryHandler();
            var response = handler.Handle(request);

            return Ok(response);
        }
        

        [HttpPost]
        public IActionResult Add([FromBody] AddCustomerRequest request)
        {
            var handler = new AddCustomerCommandHandler();
            var response = handler.Handle(request);
            return Created("", response);
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Remove([FromRoute]Guid id)
        {
            var request = new RemoveCustomerByIdRequest() { Id = id};
            var handler = new RemoveCustomerByIdCommandHandler();
            var response = handler.Handle(request);
            
            return Ok(response);
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Update([FromRoute]Guid id, [FromBody]UpdateCustomerRequest request)
        {
            request.Id = id;
            var handler = new UpdateCustomerCommandHandler();

            var response = handler.Handle(request);

            return Ok(response);
        }
    }


    


}
