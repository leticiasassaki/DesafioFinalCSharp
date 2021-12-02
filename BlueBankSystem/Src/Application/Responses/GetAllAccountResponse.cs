using BlueBank.System.Domain.OrderManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.System.Application.Responses
{
    public class GetAllAccountResponse
    {
        public Guid Id { get; set; }
        public string CustomerId { get; set; }
        public decimal Balance { get; set; }
        public bool IsActive { get; set; }
    }
}
