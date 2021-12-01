using BlueBank.System.Application.Requests;
using BlueBank.System.Application.Queries;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlueBank.System.Application.Commands;
using BlueBank.System.Application.Interfaces;
using BlueBank.System.Data.Repositories;
using BlueBank.System.Data.Contexts;
using BlueBank.System.Domain.OrderManagement.Interfaces;
using BlueBank.System.Application.Interfaces;

namespace BlueBank.System.Services.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromServices] IGetAllCustomerQuery query)
        {           
            return Ok(query.Handle(new GetAllCustomerRequest()));
        }
        

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById([FromServices] IGetCustomerByIdQuery query, [FromRoute] Guid id)
        {
            var request = new GetCustomerByIdRequest() { Id = id };

            return Ok(query.Handle(request));
        }
        
        
        [HttpPost]
        public IActionResult Add([FromServices] IAddCustomerCommand command, [FromBody] AddCustomerRequest request)
        {
            return Created("", command.Handle(request));
        }
        
        [HttpDelete]
        [Route("{id}")]
        public IActionResult Remove([FromServices] IRemoveCustomerByIdCommand command, [FromRoute]Guid id)
        {
            var request = new RemoveCustomerByIdRequest() { Id = id};
                       
            return Ok(command.Handle(request));
        }
        
        [HttpPut]
        [Route("{id}")]
        public IActionResult Update([FromServices] IUpdateCustomerCommand command, [FromRoute]Guid id, [FromBody]UpdateCustomerRequest request)
        {
             
            request.Id = id;
            try
            {
                return Ok(command.Handle(request));
            } catch(ArgumentException ex)
            {               
                return BadRequest(new { ex.Message });
            }            
        }

        [HttpPatch]
        [Route("{id}")]
        public IActionResult ChangeStatus([FromServices] ICustomerChangeStatusCommand command, [FromRoute] Guid id, [FromBody]ChangeStatusRequest request)
        {
            request.Id = id;            

            return Ok(command.Handle(request));
        }








    }


    


}
