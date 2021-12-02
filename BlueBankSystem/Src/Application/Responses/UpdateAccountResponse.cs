﻿using System;

namespace BlueBank.System.Application.Responses
{
    public class UpdateAccountResponse
    {
        public Guid Id { get; set; }
        public String CustomerId { get; set; }
        public decimal Balance { get; set; }
    }
}