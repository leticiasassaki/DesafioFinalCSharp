using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.System.Application.Responses
{
    public class ChangeStatusResponse    
    {
        public Guid Id { get; set; }
        public bool IsActive { get; set; }
    }
}
