using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.System.Application.Responses
{
    public class AddTransactionResponse
    {
        public Guid Id { get; set; }
        public Guid AccountOrigin { get; set; }
        public Guid AccountRecipient { get; set; }
        public DateTime Date { get; set; }
        public decimal Value { get; set; }

    }
}
