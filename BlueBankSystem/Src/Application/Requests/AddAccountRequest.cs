using BlueBank.System.Domain.OrderManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.System.Application.Requests
{
    public class AddAccountRequest
    {
        public Guid CustomerId { get; set; }
        public decimal Balance { get; set; }
    }
}
