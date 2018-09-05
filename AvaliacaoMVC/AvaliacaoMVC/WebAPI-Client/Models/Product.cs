using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI_Client.Models
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