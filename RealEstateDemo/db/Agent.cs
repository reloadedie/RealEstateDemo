﻿using System;
using System.Collections.Generic;

#nullable disable

namespace RealEstateDemo.db
{
    public partial class Agent
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string FirstName { get; set; }
        public int? ShareOfCommission { get; set; }
    }
}
