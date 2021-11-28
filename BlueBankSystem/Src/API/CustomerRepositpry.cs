using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueBank.System.Services.API
{   //ESTA CLASS FOI APENAS PARA SIMULAR BANCO DE DADOS: TODO
    public static class CustomerRepository
    {
        public static Dictionary<Guid, string> Customers { get; set; } = new Dictionary<Guid, string>();

       
    }
}
