﻿using MainApp.Domain.Common;

namespace MainApp.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Value { get; set; }
    }
}
