using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.System.Application.Responses
{
    public class UpdateAccountResponse
    {
        public Guid AccountId { get; set; }

        public decimal Balance { get; set; }
    }
}
