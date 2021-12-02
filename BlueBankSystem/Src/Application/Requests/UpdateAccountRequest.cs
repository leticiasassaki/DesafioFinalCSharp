﻿using System;

namespace BlueBank.System.Application.Requests
{
    public class UpdateAccountRequest
    {
        public Guid Id { get; set; }
        public String CustomerId { get; set; }
        public decimal Balance { get; set; }
    }
}