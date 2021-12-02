using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.System.Application.Requests
{
    public class AddTransactionRequest
    {
        public Guid AccountOrigin { get; set; }
        public Guid AccountRecipient { get; set; }        
        public decimal Value { get; set; }
    }
}
