using BlueBank.System.Application.Requests;
using BlueBank.System.Application.Queries;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlueBank.System.Application.Commands;
using BlueBank.System.Application.Interface;
using BlueBank.System.Data.Repositories;
using BlueBank.System.Data.Contexts;
using BlueBank.System.Domain.OrderManagement.Interfaces;

namespace BlueBank.System.Services.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
       

           /*   
        [HttpGet]
        public IActionResult Get()
        {

            var query = new GetAllCustomerQuery(_repository);

            var response = query.Handle(new GetAllCustomerRequest());
            return Ok(response);

            return Ok();
        }*/

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById([FromServices] IGetCustomerByIdQuery query, [FromRoute] Guid id)
        {
            var request = new GetCustomerByIdRequest() { Id = id };

            
            var response = query.Handle(request);

            return Ok(response);
        }
        
        /*
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
            var command = new RemoveCustomerByIdCommand(_repository);
            var response = command.Handle(request);
            
            return Ok(response);
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Update([FromRoute]Guid id, [FromBody]UpdateCustomerRequest request)
        {
            request.Id = id;
            var command = new UpdateCustomerCommand(_repository);

            var response = command.Handle(request);

            return Ok(response);
        }*/
    }


    


}
