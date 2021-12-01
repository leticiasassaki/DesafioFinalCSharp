using BlueBank.System.Services.API.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BlueBank.Sytem.Teste.Api.Controller
{
    public class CostumerControllerTeste
    {
        [Fact]
        public void Test1()
        {
            var Customer = new CustomerController();
            var result = Client.GetAsync("http://localhost:5000/api/customer");
        }

        public HttpClient Client { get; set; }

    }
}
