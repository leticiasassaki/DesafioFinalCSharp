using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlueBank.System.Services.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        //APENAS PARA SIMULAR BANCO DE DADOS: TODO

        private Dictionary<int, string> Customers { get; set; }

        public CustomerController()
        {
            Customers = new Dictionary<int, string>();
        }

        [HttpGet]
        public void Get()
        {
            
        }
    }
}
