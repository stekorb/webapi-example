using System;

namespace Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }
        public string Company { get; set; }
        public int CompanyCode { get; set; }
    }
}
