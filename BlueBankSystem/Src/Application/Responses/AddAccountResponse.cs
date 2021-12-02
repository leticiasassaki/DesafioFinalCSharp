﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBank.System.Application.Responses
{
    public class AddAccountResponse
    {
        public Guid Id { get; set; }
        public string CustomerId { get; set; }
        public decimal Balance { get; set; }
    }
}
